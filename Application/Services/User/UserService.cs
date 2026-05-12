using Application.DataTransferObject;
using Domain.Entities;
using Application.Repositories;


namespace Application.Services.User;
public class UserService : IUserService
{
    private readonly IGenericRepository<UserEntity> _userRepository;
    public UserService(IGenericRepository<UserEntity> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserDto
        {
            Id = u.Id,
            FullName = u.FullName,
            Email = u.Email,
            Mobile = u.Mobile,
            Password = u.Password
        }).ToList();
    }

    public async Task<UserDto?> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
            return null;

        return new UserDto
        {
            Id = user.Id,
            FullName = user.FullName,
            Email = user.Email,
            Mobile = user.Mobile,
            Password = user.Password
        };
    }

    public async Task CreateUserAsync(UserDto userDto)
    {
        var newUser = new UserEntity
        {
            Id = Guid.NewGuid(),
            FullName = userDto.FullName,
            Email = userDto.Email,
            Mobile = userDto.Mobile,
            Password = userDto.Password
        };

        await _userRepository.AddAsync(newUser);
        await _userRepository.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(UserDto userDto)
    {
        var user = await _userRepository.GetByIdAsync(userDto.Id);
        if (user == null) return;

        user.FullName = userDto.FullName;
        user.Email = userDto.Email;
        user.Mobile = userDto.Mobile;

        _userRepository.UpdateAsync(user);
        await _userRepository.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return;

        _userRepository.DeleteAsync(user);
        await _userRepository.SaveChangesAsync();
    }
}
