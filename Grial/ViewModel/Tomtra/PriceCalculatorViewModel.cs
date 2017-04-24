using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UXDivers.Artina.Grial.ViewModel.Tomtra
{
    public class PriceCalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PriceCalculatorViewModel()
        {
            _bankingProduct = string.Empty;
            _startDate = DateTime.Today;
            _endDate = DateTime.Today.AddMonths(3);
            _tenor = 3;
            _amount = 0;
        }

        private string _bankingProduct;
        public string BankingProduct{
            get
            {
                return _bankingProduct;
            }
            set
            {
                if (_bankingProduct != value)
                {
                    _bankingProduct = value;

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("BankingProduct"));
                }

            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("StartDate"));
                }

            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("EndDate"));
                }

            }
        }

        private int _tenor;
        public int Tenor
        {
            get
            {
                return _tenor;
            }
            set
            {
                if (_tenor != value)
                {
                    _tenor = value;

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("Tenor"));
                }

            }
        }

        private int _amount;
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (_amount != value)
                {
                    _amount = value;

                    PropertyChanged?.Invoke(this,
    new PropertyChangedEventArgs("Amount"));
                }

            }
        }
    }
}
