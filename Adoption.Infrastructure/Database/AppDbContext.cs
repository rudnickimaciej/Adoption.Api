using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Pets.Entities;
using Adoption.Infrastructure.Database.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Offert> Offerts { get; set; }
        public DbSet<Adoption.Domain.Applications.Entities.Application> Applications { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("adoption");
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new OffertConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(
            //    typeof(ReadDbContext).Assembly,
            //x => x.Namespace != "Adoption.Infrastructure.EF.Contexts.Write");
        }

    }
}
