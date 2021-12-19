using TDRSolutionFrontEnd.SharedKernel.Interfaces;
using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IUserRepository : IAsyncRepository<Usager>
    {
        Task<Usager> GetByEmailAsync(string email);
    }
}
