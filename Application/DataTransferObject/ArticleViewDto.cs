using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record ArticleViewDto
    {
        public int ArticleId { get; set; }
        public int View { get; set; }
    }
}
