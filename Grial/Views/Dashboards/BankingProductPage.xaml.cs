using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Dashboards
{
    public partial class BankingProductPage : ContentPage
    {
        public BankingProductPage(SampleCategory sampleCategory)
        {
            Title = sampleCategory.Name;
            InitializeComponent();

            BindingContext = new BankingProductViewModel(sampleCategory.Name);
        }
       
        public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
        {
            await navigation.PushAsync(new BankingProductPage(sampleCategory));
        }
    }
}
