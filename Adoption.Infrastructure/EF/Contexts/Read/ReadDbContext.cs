using Adoption.Infrastructure.DTO;
using Adoption.Infrastructure.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts.Read
{
    internal class ReadDbContext : DbContext
    {
        public DbSet<OffertModel> Offerts { get; set; }
        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("adoption");

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ReadDbContext).Assembly,
                x => x.Namespace != "Adoption.Infrastructure.EF.Contexts.Write");
        }

    }
}
