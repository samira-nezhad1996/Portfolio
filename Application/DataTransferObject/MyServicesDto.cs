using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public sealed record MyServicesDto
    {
    
        public string Title { get; set; }
        public string Logo { get; set; }
    }
}
