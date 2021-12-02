using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class UserForLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
