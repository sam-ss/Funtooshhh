﻿using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial.Views.RLC.DetailedSituation
{
    public partial class LGDetailedSituation : ContentPage
    {
        public LGDetailedSituation()
        {
            InitializeComponent();
        }
        Grial.RLC rlc;
        public LGDetailedSituation(Grial.RLC rlc)
        {
            InitializeComponent();
            this.rlc = rlc;
            //BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            var lineSituation = this.rlc.LineSituation.SingleOrDefault(a => a.StringTrcType == TrcType.LG);
            if (lineSituation == null) return;
            Chart.Series[0].ItemsSource = Chart.Series[1].ItemsSource = lineSituation.DetailedSituation;
            Chart.Title.Font = Font.OfSize("sans pro semibold", 14);
            Chart.Series[0].Opacity = 0.8;
            Chart.Series[1].Opacity = 0.8;

        }
        void secondaryAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            double label1 = Convert.ToDouble(e.LabelContent);
            e.LabelContent = label1.ToString("#,##0, K", CultureInfo.InvariantCulture);
        }
    }
}
