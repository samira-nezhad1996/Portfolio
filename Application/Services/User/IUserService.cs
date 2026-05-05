

using Application.ViewModels;

namespace Application.Services.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
    }
}
