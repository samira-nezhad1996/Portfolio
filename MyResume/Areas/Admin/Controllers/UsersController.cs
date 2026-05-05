using Application.Services.User;
using web.Controllers;
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
    }
}
