using TDRSolutionFrontEnd.Core.Entities;
namespace TDRSolutionFrontEnd.Core.Interfaces
{
    public interface IBackEndSystemService
    {
        Task sendDemandeTraitementToBackEnd(DemandeTraitement demandeTraitement, string directory);
    }
}
