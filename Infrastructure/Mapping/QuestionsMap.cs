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
    internal sealed class QuestionsMap : IEntityTypeConfiguration<QuestionsEntitiy>
    {
        public void Configure(EntityTypeBuilder<QuestionsEntitiy> builder)
        {
            builder.ToTable("QuestionsEntitiy");
            builder.Property(q => q.Title).HasMaxLength(50).IsRequired();
            builder.Property(q => q.Answer).HasMaxLength(1000).IsRequired();


        }


    }
}