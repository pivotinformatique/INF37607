using System.Threading.Tasks;

using EAISolutionFrontEnd.Core.Interfaces;
using EAISolutionFrontEnd.Core.Entities;

namespace EAISolutionFrontEnd.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _UserRepository.GetByIdAsync(id);
        }

        public async Task<User> RegisterUser(User user)
        {
            return await _UserRepository.AddAsync(user);
        }

        public async Task UpdateUser(User user)
        {
            await _UserRepository.UpdateAsync(user);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _UserRepository.GetByEmailAsync(email);
        }
        public async Task<User> AuthenticateUser(string email, string password)
        {
            User user = await _UserRepository.GetByEmailAsync(email);
            if (user != null)
                if (user.Password == password) return user;
            return null;
        }
    }
}
