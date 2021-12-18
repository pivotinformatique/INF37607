using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TDRSolutionFrontEnd.Core;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class UserRepository : EfRepository<Usager>, IUserRepository
    {
        public UserRepository(TDRSolutionFrontEndContext eAISolutionFrontEndContext) : base(eAISolutionFrontEndContext)
        {
        }

        public Task<Usager?> GetByEmailAsync(string email)
        {
            return _TDRSolutionFrontEndContext.Usagers
              .FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
