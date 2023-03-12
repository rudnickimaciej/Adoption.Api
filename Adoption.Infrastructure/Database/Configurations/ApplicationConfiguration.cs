using Adoption.Domain.Offerts.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.Database.Configurations
{
    internal sealed class ApplicationConfiguration : IEntityTypeConfiguration<Adoption.Domain.Applications.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<Adoption.Domain.Applications.Entities.Application> builder)
        {
            builder
                .ToTable("Applications")
                .HasKey(a => a.Id);

            builder
                .Property<DateTime>("CreatedOn"); //Shadow Property    

            builder
                .Property(a => a.Status)
                .HasConversion<int>()
                .IsRequired();

            builder
              .Property(a => a.OffertId)
              .HasConversion(offertId => offertId.Value, offertId => new OffertId(offertId));

        }
    }
}
