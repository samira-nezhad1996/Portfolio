using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record PrizesDto
    {

        public string Title { get; set; }
        public string StartYear { get; set; }
        public int Rank { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
    }
}
