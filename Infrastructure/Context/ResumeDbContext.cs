using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Context
{
    public class ResumeDbContext(DbContextOptions<ResumeDbContext> options) : DbContext(options)
    {
        #region Dbset

        public DbSet<AboutMeEntitiy> AboutMe { get; set; }
        public DbSet<ArticleEntitiy> Articles { get; set; }
        public DbSet<ArticleCommentEntitiy> ArticleComments { get; set; }
        public DbSet<ArticleViewEntitiy> ArticleViews { get; set; }
        public DbSet<ContactEntitiy> Contact { get; set; }
        public DbSet<CustomersCommentsEntitiy> CustomersComments { get; set; }
        public DbSet<LastWorksEntitiy> LastWorks { get; set; }
        public DbSet<MyServicesEntitiy> MyServices { get; set; }
        public DbSet<PrizesEntitiy> Prizes { get; set; }
        public DbSet<ProfessionsEntitiy> Professions { get; set; }
        public DbSet<QuestionsEntitiy> Questions { get; set; }
        public DbSet<ResumeEntitiy> Resume { get; set; }
        public DbSet<UserEntitiy> Users { get; set; }
        public DbSet<WorkWithEntitiy> WorkWith { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
