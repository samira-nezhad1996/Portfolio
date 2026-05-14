using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MyService
{
    public sealed record MyServiceViewModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Logo { get; set; }
    }
}
