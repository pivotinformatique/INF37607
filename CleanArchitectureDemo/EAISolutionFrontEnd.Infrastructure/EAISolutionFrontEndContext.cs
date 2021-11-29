using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using EAISolutionFrontEnd.Core.Entities;

namespace EAISolutionFrontEnd.Infrastructure
{
    public class EAISolutionFrontEndContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<User> Users { get; set; }
        public EAISolutionFrontEndContext(DbContextOptions options) : base(options) { }
        public EAISolutionFrontEndContext() : base(new DbContextOptionsBuilder<EAISolutionFrontEndContext>()
                                                        .UseSqlServer(@"Server=.;Database=EAISolutionFrontEndDB;Trusted_Connection=True;")
                                                        .Options) { }
    }
}
