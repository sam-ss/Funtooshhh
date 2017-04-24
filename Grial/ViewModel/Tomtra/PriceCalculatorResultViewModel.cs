using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.ViewModel.Tomtra
{
    public class PriceCalculatorResultViewModel
    {
        //public double Outstanding { get; set; }
        //public double Limit { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Tenor { get; set; }
        public string Interest { get; set; }
        public string Price { get; set; }
        public string BankingProduct { get; set; }

        public List<Situation> Situation { get; set; }

        public List<Color> Colors { get; set; }

        
    }
}
