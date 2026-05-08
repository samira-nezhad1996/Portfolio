using Application.ViewModels.LastWorks;
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

        public async Task<IEnumerable<LastWorkViewModel>> GetAllLastWorksAsync()
        {
            var entities = await _lastWorkrepository.GetAllAsync();
            return entities.Select(e => new LastWorkViewModel
            {
                Id = e.Id, 
                Title = e.Title,
                ShortDescription = e.ShortDescription,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Logo = e.Logo
            }).ToList();
        }

        public async Task<LastWorkViewModel?> GetLastWorkByIdAsync(Guid id)
        {
            var entity = await _lastWorkrepository.GetByIdAsync(id);
            if (entity == null)
                return null;

            return new LastWorkViewModel
            {
                Id = entity.Id,
                Title = entity.Title,
                ShortDescription = entity.ShortDescription,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Logo = entity.Logo
            };
        }

        public async Task CreateLastWorkAsync(CreateLastWorkViewModel model)
        {
            var newEntity = new LastWorksEntity
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                ShortDescription = model.ShortDescription,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Logo = model.Logo 
            };

            await _lastWorkrepository.AddAsync(newEntity);
            await _lastWorkrepository.SaveChangesAsync();
        }

        public async Task UpdateLastWorkAsync(EditLastWorkViewModel model)
        {
            var entity = await _lastWorkrepository.GetByIdAsync(model.Id);
            if (entity == null) return;

            entity.Title = model.Title;
            entity.ShortDescription = model.ShortDescription;
            entity.StartDate = model.StartDate;
            entity.EndDate = model.EndDate;
            entity.Logo = model.Logo;

            _lastWorkrepository.Update(entity);
            await _lastWorkrepository.SaveChangesAsync();
        }

        public async Task DeleteLastWorkAsync(Guid id)
        {
           

            await _lastWorkrepository.DeleteAsync(id); 
            await _lastWorkrepository.SaveChangesAsync();
        }
    }
}

