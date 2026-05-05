using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping
{
    internal sealed class QuestionsMap : IEntityTypeConfiguration<QuestionsEntity>
    {
        public void Configure(EntityTypeBuilder<QuestionsEntity> builder)
        {
            builder.ToTable("Questions");
            builder.Property(q => q.Title).HasMaxLength(50).IsRequired();
            builder.Property(q => q.Answer).HasMaxLength(1000).IsRequired();


        }


    }
}