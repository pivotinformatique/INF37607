using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
