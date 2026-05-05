using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Mapping
{
    internal sealed class ResumeMap : IEntityTypeConfiguration<ResumeEntity>
    {
        public void Configure(EntityTypeBuilder<ResumeEntity> builder)
        {
            builder.ToTable("Resume");
            builder.Property(r => r.Title).HasMaxLength(50).IsRequired();
            builder.Property(r => r.ShortDescription).HasMaxLength(1000).IsRequired();
            builder.Property(r => r.Picture).HasMaxLength(500).IsRequired();
            builder.Property(r => r.Url).HasMaxLength(5000).IsRequired();

        }
    }
}


