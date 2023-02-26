using Adoption.Domain.Aggregates;
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
                .HasKey(o => o.Id);

            builder
              .Property(o => o.Id)
              .HasColumnName("OffertId")
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
                .HasMany(typeof(Domain.Entities.Application), "_applications");

            builder
                .ToTable("Offerts");

            builder
                .Property<DateTime>("CreatedOn"); //Shadow Property


        }
    }
}
