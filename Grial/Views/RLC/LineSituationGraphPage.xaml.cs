using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Views.RLC;
using UXDivers.Artina.Grial.Views.RLC.PriceCalculator;
using Xamarin.Forms;


namespace UXDivers.Artina.Grial
{
    public partial class LineSituationGraphPage : ContentPage
    {
        public RLC RLC { get; set; }
                
        public LineSituationGraphPage()
        {
            InitializeComponent();            
        }
        public LineSituationGraphPage(RLC rlc)
        {
            this.RLC = rlc;
            InitializeComponent();
            AddToolbar();
        }

        private async void Chart_SelectionChanged(object sender, Syncfusion.SfChart.XForms.ChartSelectionEventArgs e)
        {
            if (e.SelectedDataPointIndex == -1) return;
            await Navigation.PushAsync(new DetailedSituationTabbedPage(RLC, (TrcType)e.SelectedDataPointIndex));
        }

        public static async Task Navigate(RLC rlc, INavigation navigation)
        {            
            await navigation.PushAsync(new LineSituationGraphPage(rlc));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();            
            BindData();
        }
        private void BindData()
        {
            //BindingContext = this;
            Chart.Title.Font = Font.OfSize("sans pro semibold", 14);
            Chart.Series[0].Opacity = 0.8;
                Chart.Series[1].Opacity = 0.8;
            Chart.Series[0].ItemsSource = this.RLC.LineSituation;
            Chart.Series[1].ItemsSource = this.RLC.LineSituation;
            
            Chart.Series[0].SelectedDataPointIndex = Chart.Series[1].SelectedDataPointIndex = -1;
            
        }
        void secondaryAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            double label1 = Convert.ToDouble(e.LabelContent);            
            e.LabelContent = label1.ToString("#,##0, K", CultureInfo.InvariantCulture);            
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
            //var lineSituation = new ToolbarItem
            //{
            //    Icon = "home1.png",
            //    Text = "Line Situation",
            //    Priority = 0,
            //    Order = ToolbarItemOrder.Secondary,
            //    Command = new Command(NavigationToLineSituationPage)
            //};
            //ToolbarItems.Add(lineSituation);

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
            Navigation.PushAsync(new PriceCalculatorPage(RLC));
        }
        private void NavigationToHomePage(object obj)
        {
            Navigation.PopToRootAsync();
        }
        private void NavigationToLineSituationPage(object obj)
        {
            Navigation.PushAsync(new LineSituationGraphPage(this.RLC));
        }
        private void NavigationToDetailSituationPage(object obj)
        {
            Navigation.PushAsync(new DetailedSituationTabbedPage(this.RLC,TrcType.LC));
        }
    }
}
