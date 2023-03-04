using Adoption.Domain.Aggregates;
using Adoption.Domain.Offert.Aggregatates;
using Adoption.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration.WriteConfigurations
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
              .HasColumnName("Id")
              .HasConversion(offertId => offertId.Value, offertId => new OffertId(offertId));
            
            builder
                .Property(o => o.OffertStatus)
                .IsRequired()
                .HasConversion<int>()
                .HasComment("Komentarz do Offert Status");


            builder
                .Property(offert => offert.Description)
                .HasConversion(description => description.Value, description => new OffertDescription(description))
                .HasMaxLength(1000);
                

            builder
                .Property(offert => offert.PetId)
                .HasConversion(petId => petId.Value, petId => new PetId(petId));

            builder
                .HasMany(typeof(Domain.Application.Entities.Application), "_applications");

            builder
                .Property(o => o.NowePoleNowaNazwa)
                .IsRequired()
                .HasDefaultValue("wartość domyślna")
                .HasMaxLength(69);
        }
    }
}
