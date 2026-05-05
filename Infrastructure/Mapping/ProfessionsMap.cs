using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class ProfessionsMap : IEntityTypeConfiguration<ProfessionEntity>
    {
        public void Configure(EntityTypeBuilder<ProfessionEntity> builder)
        {
            builder.ToTable("Professions");
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Logo).HasMaxLength(1000).IsRequired();


        }
    }
}
