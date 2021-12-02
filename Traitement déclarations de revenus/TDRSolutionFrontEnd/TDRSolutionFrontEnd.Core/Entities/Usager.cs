using TDRSolutionFrontEnd.SharedKernel;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class Usager : BaseEntity, IAggregateRoot
    {

        public string NomUsager { get; set; } = string.Empty;
        public string MotDePasse { get; set; } = string.Empty;

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public Usager()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomUsager"></param>
        /// <param name="motDePasse"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Usager(string nomUsager, string motDePasse)
        {
            NomUsager = nomUsager ?? throw new ArgumentNullException(nameof(nomUsager));
            MotDePasse = motDePasse ?? throw new ArgumentNullException(nameof(motDePasse));
        }
    }
}
