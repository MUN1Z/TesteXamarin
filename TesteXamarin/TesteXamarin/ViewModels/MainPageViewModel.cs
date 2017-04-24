using Prism.Mvvm;
using RefitExample.Service;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TesteXamarin.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        
        public string Title { get; set; }

        public ICommand BtnStartCommand { get; set; }

        public MainPageViewModel()
        {
            Title = "Teste Xamarin";

            BtnStartCommand = new Command(() =>
                {
                    GetNumber();
                }
            );
            
        }

        public async void GetNumber()
        {
            Number = await ServiceGenerator.GetService().GetNumber();

            await Task.Delay(2000);
            GetNumber();
        }
    }
}
