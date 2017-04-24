using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UXDivers.Artina.Grial
{
   public class BankingProductViewModel
    {
        string _title;
        public BankingProductViewModel(string title)
        {
            _title = title;
        }
        public List<SampleCategory> Items
        {
            get
            {
                return SamplesDefinition.BankingProductList;
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
