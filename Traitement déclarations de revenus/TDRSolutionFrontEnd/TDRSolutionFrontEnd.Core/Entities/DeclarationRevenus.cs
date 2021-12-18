using System.ComponentModel.DataAnnotations.Schema;

using TDRSolutionFrontEnd.SharedKernel;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class DeclarationRevenus : BaseEntity, IAggregateRoot
    {
        public decimal RevenusEmploi { get; set; } //= 0M;
        public decimal RevenusAutre { get; set; } //= 0M;
        public DateTime Annee { get; set; } //= DateTime.Now;
        public Usager Usager { get; set; } = new Usager();
        public AvisCotisation? AvisCotisation { get; set; } = null;
        public DateTime DateReception { get; set; } = DateTime.Now;
        public bool IsSubmitted { get; set; } = false;

        [NotMapped]
        public decimal Total { get; set; } = 0M;
        public decimal RevenusTotal() { return RevenusEmploi + RevenusAutre; }

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public DeclarationRevenus() 
        { 
        }

        public DeclarationRevenus(Usager usager)
        {
            Usager = usager;
        }

        public DeclarationRevenus(Usager usager, decimal revenusEmploi, decimal revenusAutre, DateTime annee)
        {
            Usager = usager;
            RevenusEmploi = revenusEmploi;
            RevenusAutre = revenusAutre;
            Annee = annee;
        }
    }
}
