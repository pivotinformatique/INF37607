using System.Collections.Generic;
using System.Threading.Tasks;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;
using TDRSolutionFrontEnd.Core.Specifications;

namespace TDRSolutionFrontEnd.Core.Services
{
    public class DeclarationRevenuService : IDeclarationRevenuService
    {
        private readonly IDeclarationRevenuRepository _DeclarationRevenuRepository;
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

        public async Task<DeclarationRevenus> AddDeclarationRevenu(int userId, DeclarationRevenus declarationRevenus)
        {
                Usager user = await _UserRepository.GetByIdAsync(userId);
                if (user != null) { user.AddDeclarationRevenus(declarationRevenus); }
                await _DeclarationRevenuRepository.AddAsync(declarationRevenus);
                return await _DeclarationRevenuRepository.GetByIdAsync(declarationRevenus.Id);
        }

        public async Task UpdateDeclarationRevenus(DeclarationRevenus declarationRevenus)
        {
            await _DeclarationRevenuRepository.UpdateAsync(declarationRevenus);
        }

        public async Task DeleteDeclarationRevenus(DeclarationRevenus declarationRevenus)
        {
            await _DeclarationRevenuRepository.DeleteAsync(declarationRevenus);
        }

        public async Task<IReadOnlyList<DeclarationRevenus>> GetUserDeclarationRevenus(int userId)
        {
            DeclarationsByUser spec = new DeclarationsByUser(userId);
            IReadOnlyList<DeclarationRevenus> declarationRevenus = await _DeclarationRevenuRepository.ListAsync(spec);
            List<DeclarationRevenus> declarationRevenusToReturn = new List<DeclarationRevenus>();
            foreach (DeclarationRevenus declarationRevenu in declarationRevenus)
                declarationRevenusToReturn.Add(await _DeclarationRevenuRepository.GetByIdWithAvisCotisationAsync(declarationRevenu.Id));
            declarationRevenusToReturn = declarationRevenusToReturn.OrderBy(x => x.Annee).ToList<DeclarationRevenus>();
            return (IReadOnlyList<DeclarationRevenus>)declarationRevenusToReturn;
        }

        public async Task<DeclarationRevenus> SubmitDeclarationRevenus(DemandeTraitement demandeTraitement, string directory)
        {

            await _IBackEndSystemService.sendDemandeTraitementToBackEnd(demandeTraitement, directory);
            var declaration = await GetDeclarationRevenu(Convert.ToInt32(demandeTraitement.declarationRevenus.IdDeclaration));
            declaration.IsSubmitted = true;
            await UpdateDeclarationRevenus(declaration);
            return await _DeclarationRevenuRepository.GetByIdWithAvisCotisationAsync(declaration.Id);
        }

        public async Task<AvisCotisation?> GetDeclarationAvisCotisation(int declarationId)
        {
            var declarationWithAvis = await _DeclarationRevenuRepository.GetByIdWithAvisCotisationAsync(declarationId);
            return declarationWithAvis?.AvisCotisation;
        }
    }
}
