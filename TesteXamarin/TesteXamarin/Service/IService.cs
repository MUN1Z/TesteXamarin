using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteXamarin.Model;

namespace TesteXamarin.Service
{
    public interface IService
    {

        [Get("/aleatoryInteger")]
        Task<string> GetNumber();

        [Get("/data")]
        Task<List<Data>> GetData();

        [Put("/data")]
        Task<Data> PutData();
    }
}
