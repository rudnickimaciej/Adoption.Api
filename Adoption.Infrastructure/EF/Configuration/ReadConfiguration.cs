using Adoption.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration
{
    internal sealed class ReadConfiguration : IEntityTypeConfiguration<OffertReadModel>, IEntityTypeConfiguration<ApplicationReadModel>
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

        public void Configure(EntityTypeBuilder<ApplicationReadModel> builder)
        {
            builder.ToTable("Applications");
        }
    }
}
