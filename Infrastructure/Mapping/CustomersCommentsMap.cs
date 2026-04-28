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
    internal sealed class CustomersCommentsMap : IEntityTypeConfiguration<CustomersCommentsEntitiy>
    {
        public void Configure(EntityTypeBuilder<CustomersCommentsEntitiy> builder)
        {
            builder.ToTable("CustomersComments");
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(a => a.profession).HasMaxLength(5).IsRequired();
            builder.Property(a => a.Starts).HasMaxLength(50).IsRequired();
            builder.Property(a => a.CommenterUrl).HasMaxLength(500).IsRequired();

        }
    }
}