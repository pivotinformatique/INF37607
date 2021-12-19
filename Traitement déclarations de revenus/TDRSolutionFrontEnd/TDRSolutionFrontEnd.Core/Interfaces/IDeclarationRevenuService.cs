using System.Collections.Generic;
using System.Threading.Tasks;

using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IDeclarationRevenuService
    {

        Task<DeclarationRevenus> GetDeclarationRevenu(int id);
        Task<DeclarationRevenus> AddDeclarationRevenu(int userId, DeclarationRevenus declarationRevenus);
        Task UpdateDeclarationRevenus(DeclarationRevenus declarationRevenus);
        Task DeleteDeclarationRevenus(DeclarationRevenus declarationRevenus);
        Task<DeclarationRevenus> SubmitDeclarationRevenus(DemandeTraitement demandeTraitement, string directory);
        Task<IReadOnlyList<DeclarationRevenus>> GetUserDeclarationRevenus(int userId);
        Task<AvisCotisation?> GetDeclarationAvisCotisation(int id);
        //Task UpdateAvisCotisation(int declarationId, AvisCotisation avisCotisation);
        //Task<DeclarationRevenus> AddAvisCotisation(int declarationId, AvisCotisation avisCotisation);

    }
}
