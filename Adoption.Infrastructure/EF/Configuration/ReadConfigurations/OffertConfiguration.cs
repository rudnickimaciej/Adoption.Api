using Adoption.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration.ReadConfigurations
{
    internal sealed class OffertConfiguration : IEntityTypeConfiguration<OffertModel>
    {
        public void Configure(EntityTypeBuilder<OffertModel> builder)
        {
            builder
                .ToTable("Offerts2")
                .HasKey(o => o.Id);

            builder
                .HasMany(o => o.Applications)
                .WithOne(a => a.Offert);

        }
    }
}
