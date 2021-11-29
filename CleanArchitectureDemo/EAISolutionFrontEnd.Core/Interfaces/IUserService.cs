using System.Threading.Tasks;

using EAISolutionFrontEnd.Core.Entities;

namespace EAISolutionFrontEnd.Core.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);

        Task<User> GetUserByEmail(string email);
        Task<User> RegisterUser(User user);

        Task UpdateUser(User user);
        Task<User> AuthenticateUser(string email, string password);

    }
}
