using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Dataprovider;
using UXDivers.Artina.Grial.Models;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC.PriceCalculator
{
    public partial class SelectBankingProductPage : ContentPage
    {

        public SelectBankingProductPage()
        {
            InitializeComponent();
            //BindingContext = BankingProductProvider.GetBankingProducts();            

        }
        //public SelectBankingProductPage()
        //{
        //    InitializeComponent();
        //    BindingContext = BankingProductProvider.GetBankingProducts();
        //}
        private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            var rlc = ((ListView)sender).SelectedItem as BankingProduct;
            //var sampleCategory = (SampleCategory)selectedItem;
            PriceCalculatorPage.BankingProduct = rlc.Name;
            await Navigation.PopAsync();
        }

    }
}
