using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Prism.Mvvm;
using System;

namespace TesteXamarin.ViewModels
{
    public class LinePageViewModel : BindableBase
    {

        public PlotModel Model { get; set; }

        public PlotModel Model2 { get; set; }

        public string Title { get; set; }

        public LinePageViewModel()
        {

            Title = "Line";

            Model = generatePlotModel();
            Model2 = generatePlotModel2();

        }

        private PlotModel generatePlotModel()
        {
            var model = new PlotModel { Title = "Teste de linha com pontos" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Maximum = 10, Minimum = 0 });
            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
            };

            series1.Points.Add(new DataPoint(0.0, 1.0));
            series1.Points.Add(new DataPoint(1.0, 4.0));
            series1.Points.Add(new DataPoint(2.0, 8.0));
            series1.Points.Add(new DataPoint(3.0, 5.0));
            series1.Points.Add(new DataPoint(4.0, 9.0));
            series1.Points.Add(new DataPoint(5.0, 2.0));

            model.Series.Add(series1);            
            return model;
        }

        private PlotModel generatePlotModel2()
        {
            var a = new PlotModel { Title = "Teste de linha com função cos" };
            a.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));

            return a;
        }
    }
}
