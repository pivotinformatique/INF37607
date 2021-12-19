
namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class DeclarationForDetailedDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal RevenusEmploi { get; set; }
        public decimal RevenusAutre { get; set; }
        public DateTime Annee { get; set; }
        public DateTime DateReception { get; set; }

        public bool IsSubmitted { get; set; }

        //Gestion avis cotisation ici
        //public ICollection<RequestItemForDetailedDto> RequestItems { get; set; }


        //public UserForDetailedDto User { get; set; }
    }
}
