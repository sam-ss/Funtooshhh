using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC.Common
{
    public partial class RlcNavBar : ContentView
    {
        public RlcNavBar()
        {
            InitializeComponent();
        }
        public void OnHamburgerIconTapped(Object sender, EventArgs e)
        {
            //Element current = this;

            //while (current.Parent != null)
            //{
            //    current = current.Parent;
            //    if (current.GetType().Name == "RootPage")
            //    {
            //        break;
            //    }
            //}

            //var master = current as MasterDetailPage;

            //if (master != null)
            //{
            //    master.IsPresented = true;
            //}
            Navigation.PopAsync();
        }

        public async void OnCogIconTapped(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}
