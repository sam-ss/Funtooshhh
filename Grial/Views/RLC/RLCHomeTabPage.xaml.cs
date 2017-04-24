using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{ 
    public partial class RLCHomeTabPage : TabbedPage
    {
        public RLCHomeTabPage()
        {
            InitializeComponent();
            BindingContext = this;
            Title = "Risk Legal Counterpart";            
          
        }
    }
}
