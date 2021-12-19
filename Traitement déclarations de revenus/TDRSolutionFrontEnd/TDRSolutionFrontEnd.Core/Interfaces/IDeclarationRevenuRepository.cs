using System.Threading.Tasks;

using TDRSolutionFrontEnd.SharedKernel.Interfaces;
using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IDeclarationRevenuRepository : IAsyncRepository<DeclarationRevenus>
    {
        Task<DeclarationRevenus?> GetByIdWithAvisCotisationAsync(int id);
    }
}
