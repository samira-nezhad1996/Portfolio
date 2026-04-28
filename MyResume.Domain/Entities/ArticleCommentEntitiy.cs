using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class ArticleCommentEntitiy : BaseEntity
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Comment { get; set; }
        public int ArticleId { get; set; }

        #region Relations
        [ForeignKey(nameof(ArticleId))]
        public ArticleEntitiy? Article { get; set; }

        #endregion
    }
}
