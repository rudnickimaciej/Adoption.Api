using Adoption.Domain.Offerts.Aggregates;
using Adoption.Domain.Offerts.ValueObjects;
using Adoption.Domain.Pets.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.Database.Configurations
{
    internal sealed class OffertConfiguration : IEntityTypeConfiguration<Offert>
    {
        public void Configure(EntityTypeBuilder<Offert> builder)
        {
            builder
                .ToTable("Offerts")
                .HasKey(o => o.Id);

            builder
              .Property(o => o.Id)
              .HasConversion(offertId => offertId.Value, offertId => new OffertId(offertId));

            builder
                .Property(o => o.OffertStatus)
                .IsRequired()
                .HasConversion<int>();


            builder
                .Property(offert => offert.Description)
                .HasConversion(description => description.Value, description => new OffertDescription(description))
                .HasMaxLength(1000);


            builder
                .Property(offert => offert.PetId)
                .HasConversion(petId => petId.Value, petId => new PetId(petId));

            builder
                .HasMany(typeof(Adoption.Domain.Applications.Entities.Application), "_applications");

            builder
                .Property(o => o.Papapap)
                .IsRequired()
                .HasDefaultValue(2)
                .HasMaxLength(69);
        }
    }
}
