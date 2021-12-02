using TDRSolutionFrontEnd.SharedKernel;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class Contribuable : Usager
    {

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty ;
        public string NAS { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string Courriel { get; set; } = string.Empty;
        public string TelephonePrincipal { get; set; } = string.Empty;
        public string TelephoneSecondaire { get; set; } = string.Empty;
        public string Citoyennete { get; set; } = string.Empty;

        /// <summary>
        /// Exigé par EFCore
        /// </summary>
        public Contribuable()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="nAS"></param>
        /// <param name="adresse"></param>
        /// <param name="courriel"></param>
        /// <param name="telephonePrincipal"></param>
        /// <param name="telephoneSecondaire"></param>
        /// <param name="citoyennete"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Contribuable(string nom, string prenom, string nAS, string adresse, string courriel, string telephonePrincipal, string telephoneSecondaire, string citoyennete)
        {
            Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            Prenom = prenom ?? throw new ArgumentNullException(nameof(prenom));
            NAS = nAS ?? throw new ArgumentNullException(nameof(nAS));
            Adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            Courriel = courriel ?? throw new ArgumentNullException(nameof(courriel));
            TelephonePrincipal = telephonePrincipal ?? throw new ArgumentNullException(nameof(telephonePrincipal));
            TelephoneSecondaire = telephoneSecondaire ?? throw new ArgumentNullException(nameof(telephoneSecondaire));
            Citoyennete = citoyennete ?? throw new ArgumentNullException(nameof(citoyennete));
        }

    }
}
