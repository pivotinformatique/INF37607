using System.ComponentModel.DataAnnotations.Schema;

using TDRSolutionFrontEnd.SharedKernel;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class DeclarationRevenus : BaseEntity, IAggregateRoot
    {
        public Contribuable Contribuable { get; set; } = new Contribuable();
        public decimal RevenusEmploi { get; set; }
        public decimal RevenusAutre { get; set; }
        public DateTime DateReception { get; set; } = DateTime.Now;

        [NotMapped]
        public decimal Total { get; set; } = 0M;
        public decimal RevenusTotal() { return RevenusEmploi + RevenusAutre; }

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public DeclarationRevenus() 
        { 
        }

        public DeclarationRevenus(Contribuable contribuable, decimal revenusEmploi, decimal revenusAutre)
        {
            Contribuable = contribuable;
            RevenusEmploi = revenusEmploi;
            RevenusAutre = revenusAutre;
        }
    }
}
