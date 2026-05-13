using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Portfolio
{
    public sealed record  PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Picture { get; set; }
    }
}
