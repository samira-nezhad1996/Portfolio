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
    internal sealed  class ArticleViewMap : IEntityTypeConfiguration<ArticleViewEntity>
    {
        public void Configure(EntityTypeBuilder<ArticleViewEntity> builder)
        {
            builder.ToTable("ArticleView");
            builder.Property(a => a.ArticleId).IsRequired();
            builder.Property(a => a.View).IsRequired();
        }  
    }
}

