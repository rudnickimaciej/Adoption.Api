﻿using Adoption.Domain.Aggregates;
using Adoption.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adoption.Infrastructure.EF.Configuration.WriteConfigurations
{
    internal sealed class ApplicationConfiguration :  IEntityTypeConfiguration<Domain.Entities.Application>
    {     
        public void Configure(EntityTypeBuilder<Domain.Entities.Application> builder)
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
                .HasOne(a => a.Offert);
        }
    }
}
