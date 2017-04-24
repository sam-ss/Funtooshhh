using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Dataprovider;


namespace UXDivers.Artina.Grial
{
    public class RLCFavouritesTabViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private RLC _selectedRLC;
        public List<RLC> Items
        {
            get
            {
                return RLCDataProvider.RLCList;
            }
        }
        public RLC SelectedRLC
        {
            get
            {
                return _selectedRLC;
            }

            set
            {
                if (value != _selectedRLC)
                {
                    _selectedRLC = value;

                    RaisePropertyChanged("SelectedRLC");
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
