
using Application.DataTransferObject;

namespace Application.Services.Portfolio
{
    public interface IPortfolioService
    {

        Task InsertPortfolioAsync(PortfolioDto portfolio);
        Task UpdatePortfolioAsync(PortfolioDto portfolio);
        Task<PortfolioDto> GetPortfolioByIdAsync(Guid Id);
        Task DeletePortfolioAsync(Guid Id);
        Task<List<PortfolioDto>> GetAllPortfolioAsync();

    }
}
