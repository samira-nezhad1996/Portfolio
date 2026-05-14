using Application.DataTransferObject;

namespace Application.Services.MyServices
{
    public interface IMyServiceService
    {
        Task InsertMyServiceAsync(MyServicesDto myService);
        Task UpdateMyServiceAsync(MyServicesDto myService);
        Task<MyServicesDto> GetMyServiceByIdAsync(Guid id);
        Task DeleteMyServiceAsync(Guid id);
        Task<IEnumerable<MyServicesDto>> GetAllServicesAsync(); 


    }
}
