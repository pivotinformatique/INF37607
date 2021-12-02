using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class TDRSolutionFrontEndContext : DbContext
    {
        public DbSet<DeclarationRevenus> DeclarationRevenus { get; set; }
        public DbSet<AvisCotisation> AvisCotisation { get; set; }
        public DbSet<Usager> Usagers { get; set; }
        public TDRSolutionFrontEndContext(DbContextOptions options) : base(options) { }

        public TDRSolutionFrontEndContext() : base(new DbContextOptionsBuilder<TDRSolutionFrontEndContext>()
                    .UseSqlServer(@"Server=.;Database=TDRSolutionFrontEndDB;Trusted_Connection=True;")
                    .Options)
        { }

    }

}
