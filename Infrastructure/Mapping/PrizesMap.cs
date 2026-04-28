using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapping
{
    internal sealed class PrizesMap : IEntityTypeConfiguration<PrizesEntitiy>
    {
        public void Configure(EntityTypeBuilder<PrizesEntitiy> builder)
        {
            builder.ToTable("Prizes");
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(p => p.StartYear).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Rank).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Logo).HasMaxLength(1000).IsRequired();
            builder.Property(p => p.Url).HasMaxLength(500).IsRequired();
        }
    }
}

