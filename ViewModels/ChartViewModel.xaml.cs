using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace Compte_CAMALEX
{
    public class ChartViewModel
    {
        public ISeries[] Series { get; set; }
            = new ISeries[]
            {
                new LineSeries<double>
                {
                    DataLabelsSize = 20,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Blue),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                    DataLabelsFormatter = (point) => point.PrimaryValue.ToString("C2"),
                    Values = new double[] { 200, 1854.20, 1514.55, 2156.90, 1230, 740, 620, 223 },
                    Name = "SOLDE",
                    Fill = null
                }
            };
    }
}
