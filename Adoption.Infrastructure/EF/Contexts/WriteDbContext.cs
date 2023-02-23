using Adoption.Domain.Aggregates;
using Adoption.Infrastructure.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Infrastructure.EF.Contexts
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
            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<Offert>(configuration);
            modelBuilder.ApplyConfiguration<Adoption.Domain.Entities.Application>(configuration);

            base.OnModelCreating(modelBuilder);
        }

    }
}
