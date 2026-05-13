using Application.Contract;
using Application.DataTransferObject;
using Domain.Entities;


namespace Application.Services.LastWorks
{
    public class LastWorksService : ILastWorksService
    {
        private readonly IGenericRepository<LastWorksEntity> _lastWorkrepository; 

        public LastWorksService(IGenericRepository<LastWorksEntity> lastWorkrepository)
        {
            _lastWorkrepository = lastWorkrepository;
        }

        public async Task<IEnumerable<LastWorksDto>> GetAllLastWorksAsync()
        {
            var entities = await _lastWorkrepository.GetAllAsync();
            return entities.Select(e => new LastWorksDto
            {
                Id = e.Id, 
                Title = e.Title,
                ShortDescription = e.ShortDescription,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Logo = e.Logo
            }).ToList();
        }

        public async Task<LastWorksDto?> GetLastWorkByIdAsync(Guid id)
        {
            var entity = await _lastWorkrepository.GetByIdAsync(id);
            if (entity == null)
                return null;

            return new LastWorksDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ShortDescription = entity.ShortDescription,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Logo = entity.Logo
            };
        }

        public async Task CreateLastWorkAsync(LastWorksDto lastWorksDto)
        {
            var newEntity = new LastWorksEntity
            {
                Id = Guid.NewGuid(),
                Title = lastWorksDto.Title,
                ShortDescription = lastWorksDto.ShortDescription,
                StartDate = lastWorksDto.StartDate,
                EndDate = lastWorksDto.EndDate,
                Logo = lastWorksDto.Logo 
            };

            await _lastWorkrepository.AddAsync(newEntity);
            await _lastWorkrepository.SaveChangesAsync();
        }

        public async Task UpdateLastWorkAsync(LastWorksDto lastWorksDto)
        {
            var entity = await _lastWorkrepository.GetByIdAsync(lastWorksDto.Id);
            if (entity == null) return;

            entity.Title = lastWorksDto.Title;
            entity.ShortDescription = lastWorksDto.ShortDescription;
            entity.StartDate = lastWorksDto.StartDate;
            entity.EndDate = lastWorksDto.EndDate;
            entity.Logo = lastWorksDto.Logo;

            _lastWorkrepository.UpdateAsync(entity);
            await _lastWorkrepository.SaveChangesAsync();
        }

        public async Task DeleteLastWorkAsync(Guid id)
        {
           

            await _lastWorkrepository.DeleteAsync(id); 
            await _lastWorkrepository.SaveChangesAsync();
        }
    }
}

