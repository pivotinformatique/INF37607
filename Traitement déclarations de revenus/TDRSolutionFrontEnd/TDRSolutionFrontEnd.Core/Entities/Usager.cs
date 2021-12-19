using TDRSolutionFrontEnd.SharedKernel;
using TDRSolutionFrontEnd.SharedKernel.Interfaces;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class Usager : BaseEntity, IAggregateRoot
    {

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string NAS { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string TelephonePrincipal { get; set; } = string.Empty;
        public string TelephoneSecondaire { get; set; } = string.Empty;
        public string Citoyennete { get; set; } = string.Empty;

        public virtual List<DeclarationRevenus> DeclarationRevenus { get; private set; } = new List<DeclarationRevenus>();
        
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
        public Usager(string courriel, string motDePasse)
        {
            Email = courriel ?? throw new ArgumentNullException(nameof(courriel));
            Password = motDePasse ?? throw new ArgumentNullException(nameof(motDePasse));
        }

        public Usager(string courriel, string motDePasse, string nom, string prenom, string nAS, string adresse, string telephonePrincipal, string telephoneSecondaire, string citoyennete) : this(courriel, motDePasse)
        {
            Email = courriel ?? throw new ArgumentNullException(nameof(courriel));
            Password = motDePasse ?? throw new ArgumentNullException(nameof(motDePasse));
            LastName = nom ?? throw new ArgumentNullException(nameof(nom));
            FirstName = prenom ?? throw new ArgumentNullException(nameof(prenom));
            NAS = nAS ?? throw new ArgumentNullException(nameof(nAS));
            Adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            TelephonePrincipal = telephonePrincipal ?? throw new ArgumentNullException(nameof(telephonePrincipal));
            TelephoneSecondaire = telephoneSecondaire ?? throw new ArgumentNullException(nameof(telephoneSecondaire));
            Citoyennete = citoyennete ?? throw new ArgumentNullException(nameof(citoyennete));
        }

        public void AddDeclarationRevenus(DeclarationRevenus declarationRevenus) { DeclarationRevenus.Add(declarationRevenus); }
    }
}
