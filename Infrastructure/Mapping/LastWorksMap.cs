using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class LastWorksMap : IEntityTypeConfiguration<LastWorksEntity>
    {
        public void Configure(EntityTypeBuilder<LastWorksEntity> builder)
        {
            builder.ToTable("LastWorks");
            builder.Property(l => l.Title).HasMaxLength(50).IsRequired();
            builder.Property(l => l.ShortDescription).HasMaxLength(1000).IsRequired();
            builder.Property(l => l.StartDate).HasMaxLength(50).IsRequired();
            builder.Property(l => l.EndDate).HasMaxLength(50).IsRequired();
            builder.Property(l => l.Logo).HasMaxLength(1000).IsRequired();
        }
    }
}

