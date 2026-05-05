using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class MyServicesMap : IEntityTypeConfiguration<MyServicesEntity>
    {
        public void Configure(EntityTypeBuilder<MyServicesEntity> builder)
        {
            builder.ToTable("MyServices");
            builder.Property(s => s.Title).HasMaxLength(500).IsRequired();
            builder.Property(s => s.Logo).HasMaxLength(1000).IsRequired();



    } }
}
