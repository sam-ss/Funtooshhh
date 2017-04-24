using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public partial class RLCRecentsTab : ContentPage
    {
        public RLCRecentsTab()
        {
            InitializeComponent();
            BindingContext = new RLCRecentsTabViewModel();
        }
        private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            var rlc = ((ListView)sender).SelectedItem as RLC;
            

            await LineSituationGraphPage.Navigate(rlc, Navigation);
        }
    }
}
