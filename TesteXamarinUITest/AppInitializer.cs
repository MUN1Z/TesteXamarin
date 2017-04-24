using System;
using Xamarin.UITest;
using Xamarin.UITest.Utils;

namespace TesteXamarinUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .WaitTimes(new WaitTimes())
                    .ApkFile(
                        @"D:\novos\TesteXamarin\TesteXamarin\TesteXamarin.Droid\bin\Release\TesteXamarin.Droid-Signed.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .AppBundle(@"D:\novos\TesteXamarin\TesteXamarin\TesteXamarin.iOS\bin\iPhoneSimulator\Debug\TesteXamarin.iOS.app")
                .StartApp();
        }

        public class WaitTimes : IWaitTimes
        {
            public TimeSpan GestureWaitTimeout
            {
                get { return TimeSpan.FromMinutes(2); }
            }

            public TimeSpan WaitForTimeout
            {
                get { return TimeSpan.FromMinutes(2); }
            }

            public TimeSpan GestureCompletionTimeout{
                get
                {
                    return TimeSpan.FromMinutes(2); 
                    
                }
    }
}
    }
}

