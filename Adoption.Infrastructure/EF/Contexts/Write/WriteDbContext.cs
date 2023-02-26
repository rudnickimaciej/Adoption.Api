using Adoption.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts.Write
{
    internal class WriteDbContext : DbContext
    {
        public DbSet<Offert> Offerts { get; set; }
        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("adoption");
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(WriteDbContext).Assembly,
                x => x.Namespace != "Adoption.Infrastructure.EF.Contexts.Read");

        }

    }
}
