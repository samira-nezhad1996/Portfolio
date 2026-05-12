using Application.DataTransferObject;
using Application.Services.User;
using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;
using Application.ViewModels.User;

namespace web.Areas.Admin.Controllers
{
    public class UsersController(IUserService _userService) :AdminBaseController
    {
        public async Task<IActionResult> Index()
        {
            var usersDto = await _userService.GetAllUsersAsync();
            var model = usersDto.Select(u => new UserViewModel
            {
                Id = u.Id,
                FullName = u.FullName,
                Email = u.Email,
                Mobile = u.Mobile
            }).ToList();
            return View(model);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var userDto = await _userService.GetUserByIdAsync(id);
            if (userDto == null) return NotFound();

            var model = new UserViewModel
            {
                Id = userDto.Id,
                FullName = userDto.FullName,
                Email = userDto.Email,
                Mobile = userDto.Mobile
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Create() => View(new CreateUserViewModel()); 

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var userDto = new UserDto 
            {
                FullName = model.FullName,
                Email = model.Email,
                Mobile = model.Mobile,
                Password = model.Password 
            };

            await _userService.CreateUserAsync(userDto);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var userDto = await _userService.GetUserByIdAsync(id);
            if (userDto == null) return NotFound();

            var editModel = new EditUserViewModel
            {
                Id = userDto.Id,
                FullName = userDto.FullName,
                Email = userDto.Email,
                Mobile = userDto.Mobile
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model) 
        {
            if (!ModelState.IsValid) return View(model);

            var userDto = new UserDto
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                Mobile = model.Mobile
            };

            await _userService.UpdateUserAsync(userDto);
            return RedirectToAction(nameof(Index));
        }

    }

}

