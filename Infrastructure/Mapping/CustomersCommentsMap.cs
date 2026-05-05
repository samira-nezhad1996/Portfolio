using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Mapping
{
    internal sealed class CustomersCommentsMap : IEntityTypeConfiguration<CustomersCommentsEntity>
    {
        public void Configure(EntityTypeBuilder<CustomersCommentsEntity> builder)
        {
            builder.ToTable("CustomersComments");
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(a => a.Profession).IsRequired();
            builder.Property(a => a.Stars).IsRequired();
            builder.Property(a => a.CommenterUrl).HasMaxLength(500).IsRequired();

        }
    }
}