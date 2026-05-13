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
    internal sealed class ArticleCommentMap : IEntityTypeConfiguration<ArticleCommentEntity>
    {
        public void Configure(EntityTypeBuilder<ArticleCommentEntity> builder)
        {
            builder.ToTable("ArticleComment");
            builder.Property(c => c.FullName).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Mobile).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Comment).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Article).WithMany(x => x.Comments).HasForeignKey(x => x.ArticleId);


        }

    }
}