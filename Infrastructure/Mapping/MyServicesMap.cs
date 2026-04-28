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
    internal sealed class MyServicesMap : IEntityTypeConfiguration<MyServicesEntitiy>
    {
        public void Configure(EntityTypeBuilder<MyServicesEntitiy> builder)
        {
            builder.ToTable("MyServices");
            builder.Property(s => s.Title).HasMaxLength(500).IsRequired();
            builder.Property(s => s.Logo).HasMaxLength(1000).IsRequired();



    } }
}
