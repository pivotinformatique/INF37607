using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IUserService
    {
        Task<Usager> GetUserById(int id);

        Task<Usager> GetUserByEmail(string email);
        Task<Usager> RegisterUser(Usager user);

        Task UpdateUser(Usager user);
        Task<Usager> AuthenticateUser(string email, string password);

    }
}
