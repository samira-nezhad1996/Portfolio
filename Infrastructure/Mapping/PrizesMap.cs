using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class PrizesMap : IEntityTypeConfiguration<PrizesEntity>
    {
        public void Configure(EntityTypeBuilder<PrizesEntity> builder)
        {
            builder.ToTable("Prizes");
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(p => p.StartYear).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Rank).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Logo).HasMaxLength(1000).IsRequired();
            builder.Property(p => p.Url).HasMaxLength(2000).IsRequired();
        }
    }
}

