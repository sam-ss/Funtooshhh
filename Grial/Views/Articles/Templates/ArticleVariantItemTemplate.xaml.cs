using System.Collections.Generic;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public partial class ArticleVariantItemTemplate : ContentView
    {
        public Situation LineSituation { get; set; }

        public ArticleVariantItemTemplate()
        {
            InitializeComponent();
            var colors = new List<Color>();
            colors.Add(Color.FromHex("#EBA068"));
            colors.Add(Color.FromHex("#FFD3B1"));
            ChartPie.ColorModel.Palette = Syncfusion.SfChart.XForms.ChartColorPalette.Custom;
            ChartPie.ColorModel.CustomBrushes = colors;
            BindingContext = new AuthorizationLineViewModel(new SampleCategory("ABC LTD"));

        }
    }
}

