using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Mapping
{
    internal sealed class PortfolioMap : IEntityTypeConfiguration<PortfolioEntity>
    {
        public void Configure(EntityTypeBuilder<PortfolioEntity> builder)
        {
            builder.ToTable("Portfolio");
            builder.Property(r => r.Title).HasMaxLength(50).IsRequired();
            builder.Property(r => r.ShortDescription).HasMaxLength(1000).IsRequired();
            builder.Property(r => r.Picture).HasMaxLength(500).IsRequired();
            builder.Property(r => r.Url).HasMaxLength(5000).IsRequired();

        }
    }
}


