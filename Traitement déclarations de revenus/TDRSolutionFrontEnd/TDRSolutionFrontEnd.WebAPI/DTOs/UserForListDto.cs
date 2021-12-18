﻿
namespace TDRSolutionFrontEnd.WebAPI.DTOs
{
    public class UserForListDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
