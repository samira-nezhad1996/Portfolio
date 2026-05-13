using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entities
{
    public class ArticleCommentEntity : BaseEntity
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Comment { get; set; }
        public Guid ArticleId { get; set; }

        #region Relations
        [ForeignKey(nameof(ArticleId))]
        public ArticleEntity? Article { get; set; }

        #endregion
    }
}
