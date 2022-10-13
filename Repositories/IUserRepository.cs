using CalculatorApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;

namespace CalculatorApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
