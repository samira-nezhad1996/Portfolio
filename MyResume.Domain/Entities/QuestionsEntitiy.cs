using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class QuestionsEntitiy : BaseEntity
    {
    
        public string Title { get; set; }
        public string Answer { get; set; }
    }
}
