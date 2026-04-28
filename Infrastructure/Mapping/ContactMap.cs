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
    internal sealed class ContactMap : IEntityTypeConfiguration<ContactEntitiy>
    {
        public void Configure(EntityTypeBuilder<ContactEntitiy> builder)
        {
            builder.ToTable("Contact");
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Mobile).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Topic).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Message).HasMaxLength(1000).IsRequired();
        }
    }
}


