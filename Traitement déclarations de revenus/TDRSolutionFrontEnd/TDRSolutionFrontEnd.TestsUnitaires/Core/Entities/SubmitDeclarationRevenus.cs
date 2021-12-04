using Xunit;
using Moq;

using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;
using TDRSolutionFrontEnd.Core.Services;

namespace TDRSolutionFrontEnd.TestsUnitaires.Core.Entities
{
    public class SubmitDeclarationRevenus
    {
        private Mock<IDeclarationRevenuRepository> _mockDeclarationRevenuRepository = new Mock<IDeclarationRevenuRepository>();
        private Mock<IUserRepository> _mockUserRepository = new Mock<IUserRepository>();


        public SubmitDeclarationRevenus()
        {
            _mockDeclarationRevenuRepository = new Mock<IDeclarationRevenuRepository>();
            _mockUserRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async void SoumettreDeclarationRevenus()
        {
            // Première étape: configurer les mocks pour qu’ils retournent les bons objets

            Contribuable user = new Contribuable { Id = 1 };
            _mockUserRepository.Setup(x =>
                  x.GetByIdAsync(user.Id)).ReturnsAsync(user);
            DeclarationRevenus declarationRevenus = new DeclarationRevenus { Id = 1 };
            declarationRevenus.Contribuable = user;
            _mockDeclarationRevenuRepository.Setup(x => x.GetByIdAsync(declarationRevenus.Id)).ReturnsAsync(declarationRevenus);



            //Deuxième étape: appeler le service

            DeclarationRevenuService service = new DeclarationRevenuService(_mockDeclarationRevenuRepository.Object, null, null);
            await service.AddDeclarationRevenu(declarationRevenus);

            //Troisième étape: vérifier les appels aux repositories:

            _mockDeclarationRevenuRepository.Verify(x => x.AddAsync(declarationRevenus), Times.Once);
            _mockDeclarationRevenuRepository.VerifyNoOtherCalls();

            //Quatrième étape: vérifier la valeur finale

            Assert.Equal(1, declarationRevenus.Contribuable.Id);
        }

    }
}
