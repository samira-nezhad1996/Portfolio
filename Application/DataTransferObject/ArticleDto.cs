using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record ArticleDto
    {
        public string Title { get; set; }
        public string ArticleBody { get; set; }
        public string Picture { get; set; }
        public int ReadTime { get; set; }
        public string Tags { get; set; }
    }
}
