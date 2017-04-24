using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.ViewModel.Tomtra;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC.PriceCalculator
{
    public partial class PriceCalculatorResultPage : ContentPage
    {
        private PriceCalculatorResultViewModel _priceCalculatorResultViewModel;
        private Grial.RLC rlc;
        public PriceCalculatorResultPage()
        {
            InitializeComponent();
        }

        public PriceCalculatorResultPage(PriceCalculatorViewModel priceCalculatorViewModel,Grial.RLC rlc)
        {
            InitializeComponent();
            this.rlc = rlc;
            _priceCalculatorResultViewModel = new PriceCalculatorResultViewModel
            {
                Name = rlc.Name,
                Country = rlc.Country,
                EndDate = priceCalculatorViewModel.EndDate,
                StartDate = priceCalculatorViewModel.StartDate,
                BankingProduct = priceCalculatorViewModel.BankingProduct,
                Tenor = String.Format("{0} Months", priceCalculatorViewModel.Tenor),
                Interest="10 %",
                Price="10,000",
                Situation= new List<Situation>
                {
                    new Situation
                    {
                        Label="Outstanding",
                        OutstandingAmount =rlc.LineSituation[0].OutstandingAmount   
                        
                    },
                    new Situation
                    {
                        Label="Availablity",
                        OutstandingAmount=(rlc.LineSituation[0].LimitAmount-rlc.LineSituation[0].OutstandingAmount)                        
                    }
                },
                Colors=new List<Color>
                {
                    Color.FromRgb(230,0,40),Color.FromRgb(35,85,140)
                }
            };
            BindingContext = _priceCalculatorResultViewModel;
            AddToolbar();
        }
        private void OnRecalculateButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void AddToolbar()
        {          
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
                Icon = "home1.png",
                Text = "Line Situation",
                Priority = 0,
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(NavigationToLineSituationPage)
            };
            ToolbarItems.Add(lineSituation);

            var detailSituation = new ToolbarItem
            {
                //Icon = "home1.png",
                Text = "Detail Situation",
                Priority = 0,
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(NavigationToDetailSituationPage)
            };
            ToolbarItems.Add(detailSituation);
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
            Navigation.PushAsync(new LineSituationGraphPage(this.rlc));
        }
        private void NavigationToDetailSituationPage(object obj)
        {
            Navigation.PushAsync(new DetailedSituationTabbedPage(this.rlc, TrcType.LC));
        }
    }
}
