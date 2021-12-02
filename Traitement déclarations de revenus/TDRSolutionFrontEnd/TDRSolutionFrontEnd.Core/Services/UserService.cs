using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Services
{
    // En pratique, le mot de passe doit être cryptée avant sauvegarde dans la BD
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<Usager> GetUserById(int id)
        {
            return await _UserRepository.GetByIdAsync(id);
        }

        public async Task<Usager> RegisterUser(Usager user)
        {
            return await _UserRepository.AddAsync(user);
        }

        public async Task UpdateUser(Usager user)
        {
            await _UserRepository.UpdateAsync(user);
        }

        public async Task<Usager> GetUserByEmail(string email)
        {
            return await _UserRepository.GetByEmailAsync(email);
        }
        public async Task<Usager> AuthenticateUser(string email, string password)
        {
            Usager user = await _UserRepository.GetByEmailAsync(email);
            if (user != null)
                if (user.MotDePasse == password) return user;
            return null;
        }
    }
}
