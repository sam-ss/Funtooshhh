using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Models;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Dataprovider
{
    public class BankingProductProvider
    {
        private static List<BankingProduct> _bankingProducts;
        public static List<BankingProduct> GetBankingProducts
        {
            get
            {
                if (_bankingProducts == null)
                    InitBankingProduct();
                return _bankingProducts;
            }
           
        }
        private static void InitBankingProduct()
        {
            _bankingProducts = new List<BankingProduct>();
            _bankingProducts.Add(new BankingProduct
            {
                Id=1,
                Name= "Import Letter Of Credit",
                BackgroundColor= Color.FromHex("#473957")
            });
            _bankingProducts.Add(new BankingProduct
            {
                Id = 1,
                Name = "Export Letter Of Credit",
                BackgroundColor = Color.FromHex("#473957")
            });
            _bankingProducts.Add(new BankingProduct
            {
                Id = 1,
                Name = "Collection",
                BackgroundColor = Color.FromHex("#473957")
            });
            _bankingProducts.Add(new BankingProduct
            {
                Id = 1,
                Name = "Letter Of Guarantee",
                BackgroundColor = Color.FromHex("#473957")
            });
            _bankingProducts.Add(new BankingProduct
            {
                Id = 1,
                Name = "Stand Alone Financing",
                BackgroundColor = Color.FromHex("#473957")
            });            
        }
    }
}
