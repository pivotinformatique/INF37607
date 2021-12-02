using TDRSolutionFrontEnd.SharedKernel;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class DemandeTraitement : BaseEntity
    {

        public DeclarationRevenus DeclarationRevenus { get; set; } = new DeclarationRevenus();
        public Contribuable Contribuable { get; set; } = new Contribuable();

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public DemandeTraitement()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="declarationRevenus"></param>
        /// <param name="contribuable"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public DemandeTraitement(DeclarationRevenus declarationRevenus, Contribuable contribuable)
        {
            DeclarationRevenus = declarationRevenus ?? throw new ArgumentNullException(nameof(declarationRevenus));
            Contribuable = contribuable ?? throw new ArgumentNullException(nameof(contribuable));
        }

    }
}
