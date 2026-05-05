using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record  AboutMeDto
    {
     
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkYear { get; set; }
        public int CompletedProject { get; set; }
        public int Customers { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
