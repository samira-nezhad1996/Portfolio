using Application.Contract;
using Application.DataTransferObject;
using Domain.Entities;

namespace Application.Services.MyServices
{
    public class MyServiceService : IMyServiceService
    {
        private readonly IGenericRepository<MyServicesEntity> _myServiceRepository;

        public MyServiceService(IGenericRepository<MyServicesEntity> myServiceRepository)
        {
            _myServiceRepository = myServiceRepository;
        }

        public async Task InsertMyServiceAsync(MyServicesDto myService)
        {
            MyServicesEntity entity = new MyServicesEntity
            {
                Title = myService.Title,
                Logo = myService.Logo
            };

            await _myServiceRepository.AddAsync(entity);
            await _myServiceRepository.SaveChangesAsync();
        }

        public async Task UpdateMyServiceAsync(MyServicesDto myService)
        {
            MyServicesEntity? entity = await _myServiceRepository.GetByIdAsync(myService.Id);

            if (entity == null)
            {
                throw new KeyNotFoundException("MyService not found.");
            }

            entity.Title = myService.Title;
            entity.Logo = myService.Logo;

            await _myServiceRepository.UpdateAsync(entity);
            await _myServiceRepository.SaveChangesAsync();
        }

        public async Task<MyServicesDto> GetMyServiceByIdAsync(Guid id)
        {
            MyServicesEntity? entity = await _myServiceRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new KeyNotFoundException("MyService not found.");
            }

            return new MyServicesDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Logo = entity.Logo,
            };
        }

        public async Task DeleteMyServiceAsync(Guid id)
        {
            MyServicesEntity? entity = await _myServiceRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new KeyNotFoundException("MyService not found.");
            }

            await _myServiceRepository.DeleteAsync(entity);
            await _myServiceRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<MyServicesDto>> GetAllServicesAsync()
        {
            var entities = await _myServiceRepository.GetAllAsync();

            return entities.Select(entity => new MyServicesDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Logo = entity.Logo
            });
        }
    }
}
