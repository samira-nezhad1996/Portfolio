using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record CustomersCommentsDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string profession { get; set; }
        public int Stars { get; set; }
        public string CommenterUrl { get; set; }
    }
}
