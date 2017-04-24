using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Navigation
{
    public partial class MainTabPage : TabbedPage
    {
        public MainTabPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public string Title
        {
            get
            {
                return "Risk Legal Counterpart";
            }
        }
    }
}
