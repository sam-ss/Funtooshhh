using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Dataprovider;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.Navigation
{
    public partial class ReferentialPage : ContentPage
    {

        public SampleCategory SampleCategory { get; set; }

        public List<Situation> DetailedLineSituation { get; set; }

        public ReferentialPage(SampleCategory sampleCategory)
        {
            InitializeComponent();
            SampleCategory = sampleCategory;
            DetailedLineSituation = sampleCategory.DetailedLineSituation;
            BindingContext = this;
        }
    }

    public class DetailSituation
    {
        public string Trc { get; set; }
        public List<BucketDetail> BucketDetail { get; set; }
        public DetailSituation Get()
        {
            var ds = new DetailSituation();
            ds.Trc = "LC";
            var bucketdetails = new List<BucketDetail>();
            string[] buckets = { "0,3d", "3d,1m", "1m,3m", "3m,6m", "6m,1y", "1y,2y", "2y,3y", "3y,5y", "5y,7y", "7y,10y", "10y,15y", "15y,20y", "20y,30y", "30y,50y" };
            var random = new Random();
            for (var i = 0; i < buckets.Length; i++)
            {
                bucketdetails.Add(new BucketDetail() { Amount = random.Next(9999), Bucket = buckets[i] });
            }
            ds.BucketDetail = bucketdetails;
            return ds;
        }
    }

    public class BucketDetail
    {
        public string Bucket { get; set; }
        public double Amount { get; set; }
    }
}
