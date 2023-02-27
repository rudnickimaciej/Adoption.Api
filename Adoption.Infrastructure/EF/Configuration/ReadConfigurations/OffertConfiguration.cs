using Adoption.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration.ReadConfigurations
{
    internal sealed class OffertConfiguration : IEntityTypeConfiguration<OffertReadModel>
    {
        public void Configure(EntityTypeBuilder<OffertReadModel> builder)
        {
            builder
                .ToTable("Offerts")
                .HasKey(o => o.Id);

            builder
                .HasMany(o => o.Applications)
                .WithOne(a => a.Offert);

        }
    }
}
