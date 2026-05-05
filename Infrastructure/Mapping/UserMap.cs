using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Mapping
{
    internal sealed class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.Property(u => u.FullName).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(300).IsRequired();
            builder.Property(u => u.Mobile).HasMaxLength(30).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(50).IsRequired();
        }
    }
}

