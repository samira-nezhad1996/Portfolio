

using Application.DataTransferObject;
using Application.ViewModels.User;

namespace Application.Services.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        Task<UserViewModel?> GetUserByIdAsync(Guid id);
        Task CreateUserAsync(CreateUserViewModel model);
        Task UpdateUserAsync(EditUserViewModel model);
        Task DeleteUserAsync(Guid id);
    }
}