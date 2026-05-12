using Application.DataTransferObject;
using Application.Services.AboutMe;
using Application.ViewModels.AboutMe;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
    public class AboutMeController(IAboutMeService _aboutMeService) : AdminBaseController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAboutMeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dto = new AboutMeDto
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                WorkYear = model.WorkYear,
                CompletedProject = model.CompletedProject,
                Customers = model.Customers,
                Email = model.Email,
                Mobile = model.Mobile
            };

            await _aboutMeService.InsertAboutMeAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var item = await _aboutMeService.GetAboutMeByIdAsync(id);

            if (item == null)
                return NotFound();

            var model = new EditAboutMeViewModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                WorkYear = item.WorkYear,
                CompletedProject = item.CompletedProject,
                Customers = item.Customers,
                Email = item.Email,
                Mobile = item.Mobile
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditAboutMeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dto = new AboutMeDto
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                WorkYear = model.WorkYear,
                CompletedProject = model.CompletedProject,
                Customers = model.Customers,
                Email = model.Email,
                Mobile = model.Mobile
            };

            await _aboutMeService.UpdateAboutMeAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _aboutMeService.DeleteAboutMeAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}