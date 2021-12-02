using System.Collections.Generic;
using System.Threading.Tasks;

using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IDeclarationRevenuService
    {

        Task<DeclarationRevenus> GetDeclarationRevenu(int id);
        Task<DeclarationRevenus> AddDeclarationRevenu(DeclarationRevenus declarationRevenus);
        Task UpdateDeclarationRevenus(DeclarationRevenus declarationRevenus);
        Task DeleteDeclarationRevenus(DeclarationRevenus declarationRevenus);
        Task<DeclarationRevenus> SubmitDeclarationRevenus(DeclarationRevenus declarationRevenus, string directory);
        Task<IReadOnlyList<DeclarationRevenus>> GetUserDeclarationRevenus(int userId);


    }
}
