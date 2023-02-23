using Adoption.Domain.Aggregates;
using Adoption.Domain.ValueObjects;
using Adoption.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration
{
    internal sealed class WriteConfiguration : IEntityTypeConfiguration<Offert>, IEntityTypeConfiguration<Adoption.Domain.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<Offert> builder)
        {
            builder
                .HasKey(o => o.Id);

            builder
              .Property(o => o.Id)
              .HasConversion(offertId => offertId.Value, offertId => new OffertId(offertId));

            builder
                .Property(offert => offert.Description)
                .HasConversion(description => description.Value, description => new OffertDescription(description));

            builder
                .Property(offert => offert.PetId)
                .HasConversion(petId => petId.Value, petId => new PetId(petId));

            builder
                .HasMany(typeof(Adoption.Domain.Entities.Application), "_applications");

            builder
                .ToTable("Offerts");

            builder
                .Property<DateTime>("CreatedOn"); //Shadow Property
            
                        
        }

        public void Configure(EntityTypeBuilder<Adoption.Domain.Entities.Application> builder)
        {
            builder
                .Property<DateTime>("Id"); //Shadow Property    
        }
    }
}
