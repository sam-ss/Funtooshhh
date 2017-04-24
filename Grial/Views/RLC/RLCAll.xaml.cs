using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public partial class RLCAll : ContentPage
    {
        public RLCAll()
        {
            InitializeComponent();
            BindingContext = new RLCAllTabViewModel();
        }
        private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            var rlc = ((ListView)sender).SelectedItem as RLC;
            //var sampleCategory = (SampleCategory)selectedItem;

            await LineSituationGraphPage.Navigate(rlc, Navigation);
        }
    }
}
