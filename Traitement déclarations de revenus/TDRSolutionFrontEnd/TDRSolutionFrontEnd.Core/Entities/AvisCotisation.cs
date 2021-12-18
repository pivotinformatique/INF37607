using System.ComponentModel.DataAnnotations.Schema;

using TDRSolutionFrontEnd.SharedKernel;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class AvisCotisation : BaseEntity, IAggregateRoot
    {
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
        public AvisCotisation(decimal montantDu)
        {
            MontantDu = montantDu;
        }
    }
}
