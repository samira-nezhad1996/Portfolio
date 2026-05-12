using Application.DataTransferObject;

namespace Application.Services.AboutMe
{
    public interface IAboutMeService
    {
        Task InsertAboutMeAsync(AboutMeDto aboutMeDto);
        Task UpdateAboutMeAsync(AboutMeDto aboutMeDto);
        Task DeleteAboutMeAsync(Guid Id);
        Task<AboutMeDto> GetAboutMeByIdAsync(Guid Id);
    }
}
