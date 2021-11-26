using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EAISolutionFrontEnd.Infrastructure
{
    internal class EAISolutionFrontEndContextFactory : IDesignTimeDbContextFactory<EAISolutionFrontEndContext>
    {
        public EAISolutionFrontEndContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EAISolutionFrontEndContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=EAISolutionFrontEndDB;Trusted_Connection=True;");
            return new EAISolutionFrontEndContext(optionsBuilder.Options);
        }
    }
}
