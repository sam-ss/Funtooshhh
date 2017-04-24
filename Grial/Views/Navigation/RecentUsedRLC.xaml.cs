using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Navigation
{
    public partial class RecentUsedRLC : ContentPage
    {
        public RecentUsedRLC()
        {
            InitializeComponent();
            BindingContext = new SamplesViewModel(Navigation);
        }

        private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var sampleCategory = (SampleCategory)selectedItem;

            await TabbedPageRLC.NavigateToCategory(sampleCategory, Navigation);
        }
    }
}
