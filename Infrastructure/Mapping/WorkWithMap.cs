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
    internal sealed class WorkWithMap : IEntityTypeConfiguration<WorkWithEntitiy>
    {
        public void Configure(EntityTypeBuilder<WorkWithEntitiy> builder)
        {
            builder.ToTable("WorkWith");
            builder.Property(w => w.Title).HasMaxLength(500).IsRequired();
            builder.Property(w => w.Logo).HasMaxLength(1000).IsRequired();

        }
    }  
}


