using DotNetProject.Models;
using System.Threading.Tasks;

namespace DotNetProject.Services
{
    public interface IUser
    {
        Task<User> CreateUser(User user);
        Task<User?> GetUserById(string id);
    }
}
