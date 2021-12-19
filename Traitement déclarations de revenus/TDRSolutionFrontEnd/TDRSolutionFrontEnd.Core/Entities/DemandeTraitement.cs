using TDRSolutionFrontEnd.SharedKernel;

namespace TDRSolutionFrontEnd.Core.Entities
{
    public class DemandeTraitement : BaseEntity
    {
        public DeclarationRevenus declarationRevenus { get; set; } = new DeclarationRevenus();
        public Contribuable contribuable { get; set; } = new Contribuable();

        public class DeclarationRevenus
        {
            public string IdDeclaration { get; set; } = Guid.NewGuid().ToString();
            public decimal RevenusEmploi { get; set; }
            public decimal RevenusAutre { get; set; }
            public DateTime Annee { get; set; }
        }

        public class Contribuable
        {
            public string IdContribuable { get; set; } = Guid.NewGuid().ToString();
            public string Nom { get; set; } = string.Empty;
            public string Prenom { get; set; } = string.Empty;
            public string NAS { get; set; } = string.Empty;
            public string Adresse { get; set; } = string.Empty;
            public string Courriel { get; set; } = string.Empty;
            public string TelephonePrincipal { get; set; } = string.Empty;
            public string TelephoneSecondaire { get; set; } = string.Empty;
            public string Citoyennete { get; set; } = string.Empty;
        }
    }

}

