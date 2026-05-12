using Application.DataTransferObject;


namespace Application.Services.LastWorks
{
    public interface ILastWorksService
    {
        Task<IEnumerable<LastWorksDto>> GetAllLastWorksAsync();
        Task<LastWorksDto?> GetLastWorkByIdAsync(Guid id); 
        Task CreateLastWorkAsync(LastWorksDto lastworkDto);
        Task UpdateLastWorkAsync(LastWorksDto LastworkDt);
        Task DeleteLastWorkAsync(Guid id); 
    }
}
