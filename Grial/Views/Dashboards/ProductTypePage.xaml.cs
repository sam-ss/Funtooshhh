using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Dashboards
{
    public partial class ProductTypePage : ContentPage
    {
        public ProductTypePage(SampleCategory sampleCategory)
        {
            InitializeComponent();
            BindingContext = new ProductTypeViewModel(sampleCategory.Name);
        }
        public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
        {
            await navigation.PushAsync(new ProductTypePage(sampleCategory));
        }
    }
    public class ProductTypeViewModel
    {
        string _title;
        string _collateral;
        public ProductTypeViewModel(string title)
        {
            _title = title;
        }
        public List<SampleCategory> Items
        {
            get
            {
                return SamplesDefinition.ProductTypeList;
            }
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
