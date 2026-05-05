using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Mapping
{
    internal sealed class AboutMeMap :IEntityTypeConfiguration<AboutMeEntity>
    {
        public void Configure(EntityTypeBuilder<AboutMeEntity> builder)
        {
            builder.ToTable("AboutMe");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(1000);
            builder.Property(a => a.WorkYear).IsRequired();
            builder.Property(a => a.CompletedProject).IsRequired();
            builder.Property(a => a.Customers).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Mobile).HasMaxLength(20).IsRequired();
        }
    }
}