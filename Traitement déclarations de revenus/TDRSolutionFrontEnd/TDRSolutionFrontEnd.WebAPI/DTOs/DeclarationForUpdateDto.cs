namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class DeclarationForUpdateDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal RevenusEmploi { get; set; }
        public decimal RevenusAutre { get; set; }
        public DateTime Annee { get; set; }

    }
}
