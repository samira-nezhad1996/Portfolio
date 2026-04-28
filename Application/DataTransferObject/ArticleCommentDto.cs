using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record ArticleCommentDTO
    {
     
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Comment { get; set; }
        public int ArticleId { get; set; }


    }
}
