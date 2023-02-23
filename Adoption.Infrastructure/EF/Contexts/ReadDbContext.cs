using Adoption.Infrastructure.DTO;
using Adoption.Infrastructure.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts
{
    internal class ReadDbContext : DbContext
    {
        public DbSet<OffertReadModel> Offerts { get; set; }
        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("adoption");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<OffertReadModel>(configuration);
            modelBuilder.ApplyConfiguration<ApplicationReadModel>(configuration);
        }

    }
}
