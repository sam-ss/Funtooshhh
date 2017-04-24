using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public partial class FavouritesTab : ContentPage
    {
        RLCFavouritesTabViewModel _rlcFavouritesTabViewModel;
        public FavouritesTab()
        {
            InitializeComponent();
            _rlcFavouritesTabViewModel = new RLCFavouritesTabViewModel();
            BindingContext = _rlcFavouritesTabViewModel;
        }
    }
}
