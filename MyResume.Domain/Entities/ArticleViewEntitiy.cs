using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class ArticleViewEntitiy : BaseEntity
    {
        public int ArticleId { get; set; }
        public int View { get; set; }
    }
}
