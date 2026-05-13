using Application.Contract;
using Application.DataTransferObject;
using Domain.Entities;


namespace Application.Services.AboutMe
{
    public class AboutMeService : IAboutMeService
    {
        private readonly IGenericRepository<AboutMeEntity> _aboutmerepository;

        public AboutMeService(IGenericRepository<AboutMeEntity> aboutmerepository)
        {
            _aboutmerepository = aboutmerepository;
        }

        public async Task<AboutMeDto?> GetAboutMeByIdAsync(Guid Id)
        {
            var AboutMeEntity = await _aboutmerepository.GetByIdAsync(Id);

            if (AboutMeEntity == null)
            {
                throw new KeyNotFoundException($"AboutMe with ID {Id} not found.");
            }

            var aboutMeDto = new AboutMeDto
            {
                Id = AboutMeEntity.Id,
                Name = AboutMeEntity.Name,
                Description = AboutMeEntity.Description,
                WorkYear = AboutMeEntity.WorkYear,
                CompletedProject = AboutMeEntity.CompletedProject,
                Customers = AboutMeEntity.Customers,
                Email = AboutMeEntity.Email,
                Mobile = AboutMeEntity.Mobile
            };
            return aboutMeDto;
        }

        public async Task InsertAboutMeAsync(AboutMeDto aboutMeDto)
        {
            if (aboutMeDto.Id == Guid.Empty)
                aboutMeDto.Id = Guid.NewGuid();

            var newAboutMeEntity = new AboutMeEntity
            {
                Id = aboutMeDto.Id,
                Name = aboutMeDto.Name,
                Description = aboutMeDto.Description,
                WorkYear = aboutMeDto.WorkYear,
                CompletedProject = aboutMeDto.CompletedProject,
                Customers = aboutMeDto.Customers,
                Email = aboutMeDto.Email,
                Mobile = aboutMeDto.Mobile
            };
            await _aboutmerepository.AddAsync(newAboutMeEntity);
            await _aboutmerepository.SaveChangesAsync();
        }

        public async Task UpdateAboutMeAsync(AboutMeDto aboutMeDto)
        {
            if (aboutMeDto.Id == Guid.Empty)
            {
                throw new ArgumentException("Invalid ID for update.");
            }
            var AboutMeEntity = await _aboutmerepository.GetByIdAsync(aboutMeDto.Id);

            if (AboutMeEntity == null)
            {
                throw new KeyNotFoundException($"AboutMe with ID {aboutMeDto.Id} not found for update.");
            }

            AboutMeEntity.Name = aboutMeDto.Name;
            AboutMeEntity.Description = aboutMeDto.Description;
            AboutMeEntity.Email = aboutMeDto.Email;
            AboutMeEntity.WorkYear = aboutMeDto.WorkYear;
            AboutMeEntity.CompletedProject = aboutMeDto.CompletedProject;
            AboutMeEntity.Customers = aboutMeDto.Customers;
            AboutMeEntity.Mobile = aboutMeDto.Mobile;

            await _aboutmerepository.UpdateAsync(AboutMeEntity);
            await _aboutmerepository.SaveChangesAsync();
        }

        public async Task DeleteAboutMeAsync(Guid Id)
        {
            var AboutMeEntity = await _aboutmerepository.GetByIdAsync(Id);
            if (AboutMeEntity == null)
            {
                throw new KeyNotFoundException($"AboutMe with ID {Id} not found for deletion.");
            }
            await _aboutmerepository.DeleteAsync(AboutMeEntity);
            await _aboutmerepository.SaveChangesAsync(); 
        }
    }
}
