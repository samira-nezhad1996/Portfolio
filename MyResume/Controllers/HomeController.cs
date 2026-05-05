using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class HomeController(IGenericRepository<UserEntity> repository) : Controller
    {
      
        public async Task<IActionResult> Index()
        {
            IEnumerable<UserEntity> users = await repository.GetAllAsync();

            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
