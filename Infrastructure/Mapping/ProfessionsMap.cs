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
    internal sealed class ProfessionsMap : IEntityTypeConfiguration<ProfessionsEntitiy>
    {
        public void Configure(EntityTypeBuilder<ProfessionsEntitiy> builder)
        {
            builder.ToTable("Professions");
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Logo).HasMaxLength(1000).IsRequired();


        }
    }
}
