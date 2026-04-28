using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class ArticleEntitiy : BaseEntity
    {
      
        public string Title { get; set; }
        public string ArticleBody { get; set; }
        public string Picture { get; set; }
        public int ReadTime { get; set; }
        public string Tags { get; set; }
    }
}
