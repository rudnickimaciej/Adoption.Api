using Adoption.Infrastructure.DTO;
using Adoption.Infrastructure.EF.Configuration.ReadConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts.Read
{
    internal class ReadDbContext : DbContext
    {
        public DbSet<OffertReadModel> Offerts { get; set; }
        public DbSet<ApplicationReadModel> Applications { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
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
