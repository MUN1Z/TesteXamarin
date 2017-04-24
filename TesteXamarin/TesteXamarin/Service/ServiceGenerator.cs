using Refit;
using TesteXamarin.Service;

namespace RefitExample.Service
{
    public static class ServiceGenerator
    {
        public static IService GetService()
        {
            return RestService.For<IService>("http://80.241.208.215/ingeteam/api");
        }
    }
}
