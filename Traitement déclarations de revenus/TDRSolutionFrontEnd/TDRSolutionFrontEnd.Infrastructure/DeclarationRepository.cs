using Microsoft.EntityFrameworkCore;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class DeclarationRepository : EfRepository<DeclarationRevenus>, IDeclarationRevenuRepository
    {
        public DeclarationRepository(TDRSolutionFrontEndContext eAISolutionFrontEndContext) : base(eAISolutionFrontEndContext)
        {
        }

        public Task<DeclarationRevenus?> GetByIdWithAvisCotisationAsync(int id)
        {
            return _TDRSolutionFrontEndContext.DeclarationRevenus
              .Include(r => r.AvisCotisation)
              .FirstOrDefaultAsync(r => r.Id == id);
        }

    }
}
