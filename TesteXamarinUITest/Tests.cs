using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest;

namespace TesteXamarinUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public async void RecebendoValor()
        {
            app.Tap("BtnStart");

            await Task.Delay(3000);

            var result = app.Query("LblNumber").First(c => !c.Text.Equals("0"));

            Assert.True(result != null, "Valor recebido!");
        }
    }
}

