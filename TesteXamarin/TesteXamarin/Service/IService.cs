using System.Threading.Tasks;
using Refit;

namespace TesteXamarin.Service
{
    public interface IService
    {
        [Get("/numero/")]
        Task<int> GetNumber();
    }
}
