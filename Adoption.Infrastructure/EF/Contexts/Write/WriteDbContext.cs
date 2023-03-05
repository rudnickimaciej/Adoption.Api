using Adoption.Domain.Offerts.Aggregates;
using Adoption.Infrastructure.EF.Configuration.WriteConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts.Write
{
    internal class WriteDbContext : DbContext
    {
        public DbSet<Offert> Offerts { get; set; }
        public DbSet<Domain.Applications.Entities.Application> Applications { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("adoption");

            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new OffertConfiguration());


            //modelBuilder.ApplyConfigurationsFromAssembly(
            //    typeof(WriteDbContext).Assembly,
            //    x => x.Namespace != "Adoption.Infrastructure.EF.Contexts.Read");

        }

    }
}
