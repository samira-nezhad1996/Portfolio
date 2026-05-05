using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Context
{
    public class ResumeDbContext(DbContextOptions<ResumeDbContext> options) : DbContext(options)
    {
        #region Dbset

        public DbSet<AboutMeEntity> AboutMe { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ArticleCommentEntity> ArticleComments { get; set; }
        public DbSet<ArticleViewEntity> ArticleViews { get; set; }
        public DbSet<ContactEntity> Contact { get; set; }
        public DbSet<CustomersCommentsEntity> CustomersComments { get; set; }
        public DbSet<LastWorksEntity> LastWorks { get; set; }
        public DbSet<MyServicesEntity> MyServices { get; set; }
        public DbSet<PrizesEntity> Prizes { get; set; }
        public DbSet<ProfessionEntity> Professions { get; set; }
        public DbSet<QuestionsEntity> Questions { get; set; }
        public DbSet<ResumeEntity> Resume { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<WorkWithEntity> WorkWith { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
