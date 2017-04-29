using OxyPlot;
using OxyPlot.Series;
using Prism.Mvvm;

namespace TesteXamarin.ViewModels
{
    public class PieChartPageViewModel : BindableBase
    {

        public PlotModel Model { get; set; }

        public string Title { get; set; }

        public PieChartPageViewModel()
        {

            Title = "PieChart";

            Model = generatePlotModel();

        }
        
        private PlotModel generatePlotModel()
        {

            var model = new PlotModel { Title = "População mundial por continente" };

            var ps = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            ps.Slices.Add(new PieSlice("Africa", 1030) { IsExploded = true });
            ps.Slices.Add(new PieSlice("Americas", 929) { IsExploded = true });
            ps.Slices.Add(new PieSlice("Asia", 4157));
            ps.Slices.Add(new PieSlice("Europa", 739) { IsExploded = true });
            ps.Slices.Add(new PieSlice("Oceania", 35) { IsExploded = true });

            model.Series.Add(ps);
            
            return model;
        }
    }
}
