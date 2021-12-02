using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class TDRSolutionFrontEndContextContextFactory : IDesignTimeDbContextFactory<TDRSolutionFrontEndContext>
    {
        public TDRSolutionFrontEndContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TDRSolutionFrontEndContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=TDRSolutionFrontEndDB;Trusted_Connection=True;");

            return new TDRSolutionFrontEndContext(optionsBuilder.Options);
        }
    }
}
