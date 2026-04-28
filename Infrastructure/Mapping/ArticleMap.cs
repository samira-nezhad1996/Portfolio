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
    internal sealed class ArticleMap : IEntityTypeConfiguration<ArticleEntitiy>
    {
        public void Configure(EntityTypeBuilder<ArticleEntitiy> builder)
        {
            builder.ToTable("Article");
            builder.Property(a => a.Title).HasMaxLength(500).IsRequired();
            builder.Property(a => a.ArticleBody).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(a => a.ReadTime).IsRequired();
            builder.Property(a => a.Tags).HasMaxLength(500).IsRequired();
        }
    }
}

