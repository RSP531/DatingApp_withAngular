using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        //register user
        Task<User> Register(User user, string password);
        //login to api
        Task<User> Login(string username, string password);
        //check if user exists
        Task<bool> UserExists(string username);
    }
}