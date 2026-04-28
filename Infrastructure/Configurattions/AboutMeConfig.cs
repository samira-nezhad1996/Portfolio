
using Domain.Entities;

namespace Infrastructure.Configurattions
{
    public class AboutMeConfig : IEntityTypeConfiguration<AboutMeEntitiy>
    {
        public void Configure(EntityTypeBuilder<AboutMeEntitiy> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(1000);
            builder.Property(a => a.WorkYear).IsRequired().HasMaxLength(5);
            builder.Property(a => a.CompletedProject).IsRequired().HasMaxLength();
            builder.Property(a => a.Customers).IsRequired().HasMaxLength();



        }
    }
}
