using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapping
{
    internal sealed class UserMap : IEntityTypeConfiguration<UserEntitiy>
    {
        public void Configure(EntityTypeBuilder<UserEntitiy> builder)
        {
            builder.ToTable("User");
            builder.Property(u => u.FullName).HasMaxLength(500).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(500).IsRequired();
            builder.Property(u => u.Mobile).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(50).IsRequired();
        }
    }
}

