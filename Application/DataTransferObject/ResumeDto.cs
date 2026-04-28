using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record ResumeDto
    {

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public string Url { get; set; }
    }
}
