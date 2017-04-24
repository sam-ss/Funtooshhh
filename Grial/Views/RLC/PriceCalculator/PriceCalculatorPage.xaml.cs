using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.ViewModel.Tomtra;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC.PriceCalculator
{
    public partial class PriceCalculatorPage : ContentPage
    {
        private Grial.RLC rlc;

        private PriceCalculatorViewModel _priceCalculatorViewModel;

        public static String BankingProduct;

        public PriceCalculatorPage()
        {
            InitializeComponent();
            BankingProduct = string.Empty;
        }
        public PriceCalculatorPage(Grial.RLC rlc)
        {
            InitializeComponent();
            this.rlc = rlc;
            BankingProduct = string.Empty;
            _priceCalculatorViewModel = new PriceCalculatorViewModel();
            BindingContext = _priceCalculatorViewModel;
            AddToolbar();
            
        }

        private void OnPrimaryActionButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PriceCalculatorResultPage(_priceCalculatorViewModel, rlc));
        }

        private void entryBankingProduct_Focused(object sender, FocusEventArgs e)
        {
            Navigation.PushAsync(new SelectBankingProductPage());            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _priceCalculatorViewModel.BankingProduct = BankingProduct;
        }
        private void AddToolbar()
        {
            //var calculator = new ToolbarItem
            //{
            //    Icon = "Calculator.png",
            //    Text = "Calculator",
            //    Priority = 1,
            //    Order = ToolbarItemOrder.Primary,
            //    Command = new Command(NavigationToCalculatorPage)
            //};
            //ToolbarItems.Add(calculator);
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
