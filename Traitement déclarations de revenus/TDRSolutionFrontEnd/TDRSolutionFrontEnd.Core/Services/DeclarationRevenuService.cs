using System.Collections.Generic;
using System.Threading.Tasks;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;
using TDRSolutionFrontEnd.Core.Specifications;

namespace TDRSolutionFrontEnd.Core.Services
{
    public class DeclarationRevenuService : IDeclarationRevenuService
    {
        private readonly IDeclarationRevenuRepository _DeclarationRevenuRepository ;
        private readonly IUserRepository? _UserRepository;
        private readonly IBackEndSystemService? _IBackEndSystemService;

        public DeclarationRevenuService(IDeclarationRevenuRepository declarationRevenuRepository, IUserRepository? userRepository, IBackEndSystemService? backEndSystemService)
        {
            _DeclarationRevenuRepository = declarationRevenuRepository;
            _UserRepository = userRepository;
            _IBackEndSystemService = backEndSystemService;
        }

        public async Task<DeclarationRevenus> GetDeclarationRevenu(int id)
        {
            return await _DeclarationRevenuRepository.GetByIdAsync(id);
        }

        public async Task<DeclarationRevenus> AddDeclarationRevenu(DeclarationRevenus declarationRevenus)
        {
            return await _DeclarationRevenuRepository.AddAsync(declarationRevenus);
        }

        public async Task UpdateDeclarationRevenus(DeclarationRevenus declarationRevenus)
        {
            await _DeclarationRevenuRepository.UpdateAsync(declarationRevenus);
        }

        public async Task DeleteDeclarationRevenus(DeclarationRevenus declarationRevenus)
        {
            await _DeclarationRevenuRepository.DeleteAsync(declarationRevenus);
        }

        public Task<IReadOnlyList<DeclarationRevenus>> GetUserDeclarationRevenus(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<DeclarationRevenus> SubmitDeclarationRevenus(DeclarationRevenus declarationRevenus, string directory)
        {
            throw new NotImplementedException();
        }


    }
}
