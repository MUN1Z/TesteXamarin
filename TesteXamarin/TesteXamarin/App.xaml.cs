using Prism.Unity;
using TesteXamarin.Views;
using Xamarin.Forms;

namespace TesteXamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            Current.MainPage = new NavigationPage(new MainPage());

            //NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>("MainPage");
            Container.RegisterTypeForNavigation<PieChartPage>("PieChartPage");
            Container.RegisterTypeForNavigation<BarPage>("BarPage");
            Container.RegisterTypeForNavigation<LinePage>("LinePage");
        }
    }
}
