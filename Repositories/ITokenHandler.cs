using CalculatorApi.Models;
using System.Threading.Tasks;

namespace CalculatorApi.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
