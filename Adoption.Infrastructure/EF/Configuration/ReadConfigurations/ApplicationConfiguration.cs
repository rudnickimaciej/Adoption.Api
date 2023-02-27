using Adoption.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration.ReadConfigurations
{
    internal sealed class ApplicationConfiguration :  IEntityTypeConfiguration<ApplicationReadModel>
    {
        public void Configure(EntityTypeBuilder<ApplicationReadModel> builder)
        {
            builder
                .ToTable("Applications")
                .HasKey(a => a.Id);
        }
    }
}
