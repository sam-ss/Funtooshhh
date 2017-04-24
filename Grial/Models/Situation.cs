using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UXDivers.Artina.Grial
{
    public class Situation
    {
        private double _limitAmount;

        public string TrcType
        {
            get
            {
                return this.StringTrcType.ToString();
            }
        }

        public TrcType StringTrcType { get; set; }

        public string TenorType { get; set; }

        //public TrcType TrcType {get;set;}
        public double Availablity
        {
            get
            {
                return _limitAmount - OutstandingAmount;
            }
            set
            {
                _limitAmount = value;
            }
        }
        public double LimitAmount
        {
            get
            {
                return _limitAmount;
            }
            set
            {
                _limitAmount = value;
            }
        }

        public double OutstandingAmount { get; set; }

        public List<Situation> DetailedSituation { get; set; }

        public string Label { get; set; }


    }
}
