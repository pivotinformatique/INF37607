
namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class DeclarationsForListDto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>1</example>
        public string Id { get; set; } =  Guid.NewGuid().ToString();

        /// <summary>
        /// Main revenu
        /// </summary>
        /// <example>65000</example>
        public decimal RevenusEmploi { get; set; }

        /// <summary>
        /// Other revenus
        /// </summary>
        /// <example>4000</example>
        public decimal RevenusAutre { get; set; }

        /// <summary>
        /// Year for the declaration. 
        /// </summary>
        /// <example>2021-12-31</example>
        public DateTime Annee { get; set; }

        /// <summary>
        /// Updated when submitted
        /// </summary>
        /// <example>2021-12-31</example>
        public DateTime DateReception { get; set; }

        /// <summary>
        /// Once the declaration isSubmitted, user can't modify the declaration
        /// </summary>
        /// <example>false</example>
        public bool IsSubmitted { get; set; }
    }
}
