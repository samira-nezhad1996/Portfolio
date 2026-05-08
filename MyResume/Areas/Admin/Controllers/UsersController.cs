using Application.Services.User;
using Application.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
    public class UsersController(IUserService _userService) :AdminBaseController
    {
        public async Task<IActionResult> Index()
        {
            var model = await _userService.GetAllUsersAsync();
            return View(model);
        }


        public async Task<IActionResult> Details(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpGet]
        public IActionResult Create() => View(new CreateUserViewModel());

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            await _userService.CreateUserAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();

            var editModel = new EditUserViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                Mobile = user.Mobile
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            await _userService.UpdateUserAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _userService.DeleteUserAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }

}

