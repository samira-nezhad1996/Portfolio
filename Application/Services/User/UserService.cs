using Application.DataTransferObject;
using Application.ViewModels.User;
using Domain.Entities;


namespace Application.Services.User;
public class UserService : IUserService
{
    private readonly IGenericRepository<UserEntity> _userRepository;
    public UserService(IGenericRepository<UserEntity> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserViewModel
        {
            Id = u.Id,
            FullName = u.Fullname,
            Email = u.Email,
            Mobile = u.Mobile,
            CreateDate = u.CreateDate
        }).ToList();
    }

    public async Task<UserViewModel?> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
            return null;

        return new UserViewModel
        {
            Id = user.Id,
            FullName = user.Fullname,
            Email = user.Email,
            Mobile = user.Mobile,
            CreateDate = user.CreateDate
        };
    }

    public async Task CreateUserAsync(CreateUserViewModel model)
    {
        var newUser = new User
        {
            Id = Guid.NewGuid(),
            Fullname = model.FullName,
            Email = model.Email,
            Mobile = model.Mobile,
            CreateDate = DateTime.UtcNow
        };

        await _userRepository.AddAsync(newUser);
        await _userRepository.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(EditUserViewModel model)
    {
        var user = await _userRepository.GetByIdAsync(model.Id);
        if (user == null) return;

        user.Fullname = model.FullName;
        user.Email = model.Email;
        user.Mobile = model.Mobile;

        _userRepository.Update(user);
        await _userRepository.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return;

        _userRepository.Delete(user);
        await _userRepository.SaveChangesAsync();
    }
}
