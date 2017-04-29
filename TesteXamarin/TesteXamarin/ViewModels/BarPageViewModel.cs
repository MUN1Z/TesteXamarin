using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Prism.Mvvm;

namespace TesteXamarin.ViewModels
{
    public class BarPageViewModel : BindableBase
    {

        public PlotModel Model { get; set; }

        public string Title { get; set; }

        public BarPageViewModel()
        {
            
            Title = "Bar";

            Model = generatePlotModel();

        }

        private PlotModel generatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "",
                LegendPosition = LegendPosition.BottomCenter,
                PlotAreaBorderColor = OxyColors.Transparent
            };

            var series = new BarSeries
            {
                Title = "valor de alguma coisa",
                StrokeThickness = 0,
                FillColor = OxyColors.CornflowerBlue
            };

            series.Items.Add(new BarItem { Value = 40 });

            var series2 = new BarSeries
            {
                Title = "valor de alguma outra coisa",
                StrokeThickness = 0,
                FillColor = OxyColors.Coral
            };
            
            series2.Items.Add(new BarItem { Value = 75 });

            var series3 = new BarSeries
            {
                Title = "valor de alguma outra coisa coisada",
                StrokeThickness = 0,
                FillColor = OxyColors.BurlyWood
            };

            series3.Items.Add(new BarItem { Value = 85 });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = 100
            });

            model.Series.Add(series);
            model.Series.Add(series2);
            model.Series.Add(series3);
            return model;
        }
    }
}
