using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services.User;

public class UserService :IUserService
{
    private readonly IGenericRepository<User> _userRepository;
    public UserService(IGenericRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    public  async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();

        var model = users.Select(u => new UserViewModel
        {
            CreateDate = u.CreateDate,
            Email = u.Email,
            FullName = u.Fullname,
            Mobile = u.Mobile,

        }).ToList();
        return model;
    }
}
