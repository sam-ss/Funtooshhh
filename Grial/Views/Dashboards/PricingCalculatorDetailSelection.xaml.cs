using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Dashboards
{
    public partial class PricingCalculatorDetailSelection : ContentPage
    {
        public PricingCalculatorDetailSelection(SampleCategory sampleCategory)
        {
            Title = sampleCategory.Name;
            InitializeComponent();

            BindingContext = new PricingCalculatorDetailSelectionViewModel(sampleCategory.Name);
        }
        
         private async void OnCalculateButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PricingCalculatorResultPage());
            //await navigation.PushAsync(new PricingCalculatorDetailSelection(sampleCategory));
        }

        public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
        {
            await navigation.PushAsync(new PricingCalculatorDetailSelection(sampleCategory));
        }
    }

    public class PricingCalculatorDetailSelectionViewModel
    {
        string _title;
        string _collateral;
        public PricingCalculatorDetailSelectionViewModel(string title)
        {
            _title = title;
        }
        public string Title
        {
            get
            {
                return _title;
            }
        }



    }
}
