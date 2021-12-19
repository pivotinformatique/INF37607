using System.ComponentModel.DataAnnotations;

namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vous devez spécifier le bon format du courriel")]
        public string Email { get; set; } = String.Empty;
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Vous devez spécifier un mot de passe entre 4 et 8 caractères")]
        public string Password { get; set; } = String.Empty;

    }
}
