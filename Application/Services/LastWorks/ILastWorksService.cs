using Application.ViewModels.LastWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.LastWorks
{
    public interface ILastWorksService
    {
        Task<IEnumerable<LastWorkViewModel>> GetAllLastWorksAsync();
        Task<LastWorkViewModel?> GetLastWorkByIdAsync(Guid id); 
        Task CreateLastWorkAsync(CreateLastWorkViewModel model);
        Task UpdateLastWorkAsync(EditLastWorkViewModel model);
        Task DeleteLastWorkAsync(Guid id); 
    }
}
