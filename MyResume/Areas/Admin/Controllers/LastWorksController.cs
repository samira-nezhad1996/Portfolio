using Application.DataTransferObject;
using Application.Services.LastWorks;
using Application.ViewModels.LastWork;
using Microsoft.AspNetCore.Mvc;


namespace web.Areas.Admin.Controllers
{
    public class LastWorksController(ILastWorksService _lastWorkService) : AdminBaseController
    {
        
            public async Task<IActionResult> Index()
            {
                var itemsDto = await _lastWorkService.GetAllLastWorksAsync();

                var viewModels = itemsDto.Select(dto => new LastWorkViewModel
                {
                    Id = dto.Id, 
                    Title = dto.Title,
                    ShortDescription = dto.ShortDescription,
                    StartDate = dto.StartDate,
                    EndDate = dto.EndDate,
                    Logo = dto.Logo
                }).ToList();

                return View(viewModels);
            }

            public async Task<IActionResult> Details(Guid id)
            {
                var itemDto = await _lastWorkService.GetLastWorkByIdAsync(id);
                if (itemDto is null) return NotFound();

                var viewModel = new LastWorkViewModel
                {
                    Id = itemDto.Id, 
                    Title = itemDto.Title,
                    ShortDescription = itemDto.ShortDescription,
                    StartDate = itemDto.StartDate,
                    EndDate = itemDto.EndDate,
                    Logo = itemDto.Logo
                };
                return View(viewModel);
            }

            public IActionResult Create()
            {
                return View(new CreateLastWorkViewModel());
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(CreateLastWorkViewModel model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var dto = new LastWorksDto
                {
                    Title = model.Title,
                    ShortDescription = model.ShortDescription,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    Logo = model.Logo
                };

                await _lastWorkService.CreateLastWorkAsync(dto);
                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Edit(Guid id)
            {
                var itemDto = await _lastWorkService.GetLastWorkByIdAsync(id);
                if (itemDto is null) return NotFound();

                var viewModel = new EditLastWorkViewModel
                {
                    Id = itemDto.Id,
                    Title = itemDto.Title,
                    ShortDescription = itemDto.ShortDescription,
                    StartDate = itemDto.StartDate,
                    EndDate = itemDto.EndDate,
                    Logo = itemDto.Logo
                };
                return View(viewModel);
            }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(EditLastWorkViewModel model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var dto = new LastWorksDto
                {
                    Id = model.Id, 
                    Title = model.Title,
                    ShortDescription = model.ShortDescription,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    Logo = model.Logo
                };

                await _lastWorkService.UpdateLastWorkAsync(dto);
                return RedirectToAction(nameof(Index));
            }


            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(Guid id)
            {
                await _lastWorkService.DeleteLastWorkAsync(id);
                return RedirectToAction(nameof(Index));
            }
        }
    }