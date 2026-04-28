using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Mapping
{
    internal sealed class AboutMeMap :IEntityTypeConfiguration<AboutMeEntitiy>
    {
        public void Configure(EntityTypeBuilder<AboutMeEntitiy> builder)
        {
            builder.ToTable("Aboutme");
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(1000).IsRequired();
            builder.Property(a => a.WorkYear).HasMaxLength(5).IsRequired();
            builder.Property(a => a.CompletedProject).HasMaxLength(500).IsRequired();
            builder.Property(a => a.Customers).HasMaxLength(500).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Mobile).HasMaxLength(20).IsRequired();
        }
    }
}