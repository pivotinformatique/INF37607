using TDRSolutionFrontEnd.SharedKernel;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class AvisCotisation
    {
        public DeclarationRevenus DeclarationRevenus { get; set; } = new DeclarationRevenus();
        public decimal MontantDu { get; set; }

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public AvisCotisation()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="declarationRevenus"></param>
        /// <param name="montantDu"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AvisCotisation(DeclarationRevenus declarationRevenus, decimal montantDu)
        {
            DeclarationRevenus = declarationRevenus ?? throw new ArgumentNullException(nameof(declarationRevenus));
            MontantDu = montantDu;
        }
    }
}
