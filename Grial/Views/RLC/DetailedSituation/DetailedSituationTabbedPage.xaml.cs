using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Views.RLC.DetailedSituation;
using UXDivers.Artina.Grial.Views.RLC.PriceCalculator;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC
{
    public partial class DetailedSituationTabbedPage : TabbedPage
    {
        private Grial.RLC rlc;
        private TrcType selectedBucket;
        public DetailedSituationTabbedPage()
        {
            InitializeComponent();            
        }
        public DetailedSituationTabbedPage(Grial.RLC rlc,TrcType selectedBucket)
        {
            InitializeComponent();
            this.rlc = rlc;
            this.selectedBucket = selectedBucket;
            AddChildern();
            SetCurrentPage();
            AddToolbar();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
            //AddChildern();
            //SetCurrentPage();
            //AddToolbar();
        }

        private IEnumerable<TrcType> GetNumberOfBuckets()
        {
            var numberOfBuckets = new List<TrcType>();
            if (this.rlc == null) return numberOfBuckets;

            var trcTypes = rlc.LineSituation.DistinctBy(a => a.StringTrcType).Select(a => a.StringTrcType);
            if (trcTypes.Count() == 0) return numberOfBuckets;

            numberOfBuckets.AddRange(trcTypes);

            return trcTypes;
        }

        private void AddChildern()
        {
            var buckets = GetNumberOfBuckets();
            if (buckets.Count() == 0) return;

            Children.Clear();

            foreach (var bucket in buckets)
            {
                switch (bucket)
                {
                    case TrcType.LC:                        
                        Children.Add(new LCDetailedSituation(rlc));
                        break;
                    case TrcType.LG:
                        Children.Add(new LGDetailedSituation(rlc));
                        break;
                    case TrcType.UnspecificIR:
                        Children.Add(new UnspecificDetailedSituation(rlc));
                        break;
                    case TrcType.Unspecific:
                        Children.Add(new UnspecificDetailedSituation(rlc));
                        break;
                }
            }
        }

        private void SetCurrentPage()
        {
            if (Children.Count == 0) return;
            CurrentPage = Children[(int)selectedBucket];
        }
        private void AddToolbar()
        {
            var calculator = new ToolbarItem
            {
                Icon = "Calculator.png",
                Text = "Calculator",
                Priority = 1,
                Order = ToolbarItemOrder.Primary,
                Command = new Command(NavigationToCalculatorPage)
            };
            ToolbarItems.Add(calculator);
            var home = new ToolbarItem
            {
                Icon = "home1.png",
                Text = "Home",
                Priority = 0,
                Order = ToolbarItemOrder.Primary,
                Command = new Command(NavigationToHomePage)
            };
            ToolbarItems.Add(home);
            var lineSituation = new ToolbarItem
            {
                //Icon = "home1.png",
                Text = "Line Situation",
                Priority = 0,
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(NavigationToLineSituationPage)
            };
            ToolbarItems.Add(lineSituation);

            //var detailSituation = new ToolbarItem
            //{
            //    //Icon = "home1.png",
            //    Text = "Detail Situation",
            //    Priority = 0,
            //    Order = ToolbarItemOrder.Secondary,
            //    Command = new Command(NavigationToDetailSituationPage)
            //};
            //ToolbarItems.Add(detailSituation);

        }

        private void NavigationToCalculatorPage(object obj)
        {
            Navigation.PushAsync(new PriceCalculatorPage(rlc));
        }
        private void NavigationToHomePage(object obj)
        {
            Navigation.PopToRootAsync();
        }
        private void NavigationToLineSituationPage(object obj)
        {
            Navigation.PushAsync(new LineSituationGraphPage(rlc));
        }
        private void NavigationToDetailSituationPage(object obj)
        {
            Navigation.PushAsync(new DetailedSituationTabbedPage(rlc, TrcType.LC));
        }

        //private Dictionary<TrcType, Type> CreateBucketAndContentPageMappingDictonary()
        //{
        //    return new Dictionary<TrcType, Type>
        //    {
        //        { TrcType.LC,typeof(LCDetailedSituation) },
        //        { TrcType.LG,typeof(LGDetailedSituation) },
        //        { TrcType.Unspecific,typeof(UnspecificDetailedSituation) }                
        //    };
        //}


    }

    public static class EnumerableExtensions
    {

        /// <summary>
        /// Returns a ienumerable which is distinct by a given property key selector. If a custom equality 
        /// comparer is to be used, pass this in as the comparer. By setting the comparer default to null,
        /// the default comparer is used. 
        /// </summary>
        /// <typeparam name="T">The item type in the ienumerable</typeparam>
        /// <typeparam name="TKey">The type of the key selector (property to disinct elements by)</typeparam>
        /// <param name="coll">The source ienumerable</param>
        /// <param name="keySelector">The key selector, use a member expression in a lambda expression</param>
        /// <param name="comparer">Custom comparer to use, pass in null here to specify that default comparer is used,
        /// however, this is default set to null and not required parameter</param>
        /// <returns></returns>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> coll, Func<T, TKey> keySelector,
            IEqualityComparer<TKey> comparer = null)
        {
            if (coll == null)
                throw new ArgumentNullException("coll");
            if (keySelector == null)
                throw new ArgumentNullException("keySelector");

            var result = coll.GroupBy(keySelector, comparer).Select(g => g.First()).ToList();
            return new List<T>(result).AsEnumerable();
        }

    }

}
