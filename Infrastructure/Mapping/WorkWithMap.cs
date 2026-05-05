using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class WorkWithMap : IEntityTypeConfiguration<WorkWithEntity>
    {
        public void Configure(EntityTypeBuilder<WorkWithEntity> builder)
        {
            builder.ToTable("WorkWith");
            builder.Property(w => w.Title).HasMaxLength(500).IsRequired();
            builder.Property(w => w.Logo).HasMaxLength(1000).IsRequired();

        }
    }  
}


