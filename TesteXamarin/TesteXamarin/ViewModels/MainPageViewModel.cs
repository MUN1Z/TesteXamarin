using OxyPlot;
using Prism.Mvvm;
using Prism.Navigation;
using RefitExample.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TesteXamarin.Model;
using Xamarin.Forms;

namespace TesteXamarin.ViewModels
{
    public class MainPageViewModel : BindableBase
    {

        private readonly INavigationService _navigationService;
        
        public ICommand BtnStartCommand { get; set; }

        public ICommand BtnPieChartPageCommand { get; set; }

        public ICommand BtnBarPageCommand { get; set; }

        public ICommand BtnLinePageCommand { get; set; }

        private string _number;
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        
        private PlotModel currentPlotModel;

        public PlotModel CurrentPlotModel
        {
            get { return currentPlotModel; }
            set { SetProperty(ref currentPlotModel, value); }
        }

        public string Title { get; set; }
        
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            Title = "Teste Xamarin";
            
            BtnStartCommand = new Command(() =>
                {
                    GetNumber();
                }
            );

            BtnPieChartPageCommand = new Command(() => {
                _navigationService.NavigateAsync("PieChartPage");
            });

            BtnBarPageCommand = new Command(() => {
                _navigationService.NavigateAsync("BarPage");
            });

            BtnLinePageCommand = new Command(() => {
                _navigationService.NavigateAsync("LinePage");
            });
        }

        
        public async void GetNumber()
        {
            try
            {
                Number = await ServiceGenerator.GetService().GetNumber();
                var a = await ServiceGenerator.GetService().GetData();
                

                await Task.Delay(2000);
                GetNumber();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
