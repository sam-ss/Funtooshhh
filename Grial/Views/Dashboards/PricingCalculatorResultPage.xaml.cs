using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Dashboards
{
    public partial class PricingCalculatorResultPage : ContentPage
    {
        public PricingCalculatorResultPage()
        {
            InitializeComponent();
            BindingContext = new PostsViewModel();
        }
        private  void OnItemTapped(Object sender, EventArgs e)
        {
            //var selectedItem = ((ListView)sender).SelectedItem;
            //var post = (Post)selectedItem;
            //var articleView = new ArticleViewPage(new ArticleViewModel(post));

            //await Navigation.PushAsync(articleView);
        }
    }
}
