using Application.DataTransferObject;
using Application.Contract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Application.Services.Portfolio
{
    public class PortfolioService : IPortfolioService
    {

        private readonly IGenericRepository<PortfolioEntity> _portfolioRepository;
        public PortfolioService(IGenericRepository<PortfolioEntity> portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }


        public async Task InsertPortfolioAsync(PortfolioDto portfolio)
        {
            var entity = new PortfolioEntity
            {
                Title = portfolio.Title,
                ShortDescription = portfolio.ShortDescription,
                Picture = portfolio.Picture,
                Url = portfolio.Url
            };

            await _portfolioRepository.AddAsync(entity);
            await _portfolioRepository.SaveChangesAsync();
        }

        public async Task UpdatePortfolioAsync(PortfolioDto portfolio)
        {
            var entity = await _portfolioRepository.GetByIdAsync(portfolio.Id);

            if (entity == null)
            {
                throw new Exception("Not Found");
            }

            entity.Title = portfolio.Title;
            entity.ShortDescription = portfolio.ShortDescription;
            entity.Picture = portfolio.Picture;
            entity.Url = portfolio.Url;

            await _portfolioRepository.UpdateAsync(entity);
            await _portfolioRepository.SaveChangesAsync();
        }

        public async Task<PortfolioDto> GetPortfolioByIdAsync(Guid id)
        {
            var entity = await _portfolioRepository.GetByIdAsync(id);

            if (entity == null || entity.IsDelete)
            {
                throw new Exception("Not Found");
            }

            return new PortfolioDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ShortDescription = entity.ShortDescription,
                Picture = entity.Picture,
                Url = entity.Url
            };

        }

        public async Task DeletePortfolioAsync(Guid id)
        {
            var entity = await _portfolioRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new Exception ("Not Found");
            }

            await _portfolioRepository.DeleteAsync(entity);
            await _portfolioRepository.SaveChangesAsync();
        }

        public async Task<List<PortfolioDto>> GetAllPortfolioAsync()
        {
            var entities = await _portfolioRepository.GetQuery()
                .Where(x => !x.IsDelete)
                .ToListAsync();



            return entities.Select(entity => new PortfolioDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ShortDescription = entity.ShortDescription,
                Picture = entity.Picture,
                Url = entity.Url
            }).ToList();

        }

    }
}