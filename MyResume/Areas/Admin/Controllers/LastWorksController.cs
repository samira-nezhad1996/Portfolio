using Application.Services.LastWorks;
using Application.ViewModels.LastWorks;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
    public class LastWorksController(ILastWorksService _lastWorkrepository) : AdminBaseController
    {
        public async Task<IActionResult> Index()
        {
            var items = await _lastWorkrepository.GetAllLastWorksAsync();
            return View(items);
        }


        public async Task<IActionResult> Details(Guid id)
        {
            var item = await _lastWorkrepository.GetLastWorkByIdAsync(id);
            if (item is null) return NotFound();
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new CreateLastWorkViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateLastWorkViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            await _lastWorkrepository.CreateLastWorkAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var item = await _lastWorkrepository.GetLastWorkByIdAsync(id);
            if (item is null) return NotFound();

            var vm = new EditLastWorkViewModel
            {
                Id = item.Id,
                Title = item.Title,
                ShortDescription = item.ShortDescription,
                StartDate = item.StartDate,
                EndDate = item.EndDate,
                Logo = item.Logo
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditLastWorkViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            await _lastWorkrepository.UpdateLastWorkAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _lastWorkrepository.DeleteLastWorkAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}