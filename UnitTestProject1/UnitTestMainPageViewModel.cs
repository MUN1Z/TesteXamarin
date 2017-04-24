using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteXamarin.ViewModels;
using System.Threading.Tasks;

namespace TesteXamarin.Test
{
    [TestClass]
    public class UnitTestMainPageViewModel
    {
        [TestMethod]
        public async Task TestChangeNumber()
        {
            MainPageViewModel vm = new MainPageViewModel();

            int NumberOld = vm.Number;

            vm.BtnStartCommand.Execute(null);

            await Task.Delay(3000);
            
            Assert.IsTrue(NumberOld != vm.Number, "TestChangeNumber");
        }

        [TestMethod]
        public async Task TestNotChangeNumber()
        {
            MainPageViewModel vm = new MainPageViewModel();
            
            int NumberOld = vm.Number;
            
            vm.BtnStartCommand.Execute(null);

            await Task.Delay(3000);

            Assert.IsTrue(NumberOld == vm.Number, "TestNotChangeNumber");
        }
    }
}
