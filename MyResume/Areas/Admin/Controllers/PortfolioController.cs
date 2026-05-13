using Application.DataTransferObject;
using Application.Services.Portfolio;
using Application.ViewModels.Portfolio;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
    public class PortfolioController(IPortfolioService _portfolioService) : AdminBaseController
    {
        public async Task<IActionResult> Index()
        {
            var dtos = await _portfolioService.GetAllPortfolioAsync();

            var viewModels = dtos.Select(dto => new PortfolioViewModel
            {
                Id = dto.Id,
                Title = dto.Title,
                Picture = dto.Picture 
            }).ToList();

            return View(viewModels); 
        }

        public IActionResult Create()
        {
          
            return View(new CreatePortfolioViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Create(CreatePortfolioViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            string? pictureUrl = null;
            if (viewModel.Picture != null)
            {
                pictureUrl = $"/images/portfolio/{Guid.NewGuid()}{Path.GetExtension(viewModel.Picture)}";
            }

            var dto = new PortfolioDto
            {
                Title = viewModel.Title,
                ShortDescription = viewModel.ShortDescription,
                Picture = pictureUrl, 
                Url = viewModel.Url
            };

            await _portfolioService.InsertPortfolioAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var dto = await _portfolioService.GetPortfolioByIdAsync(id);

            if (dto == null)
            {
                return NotFound(); 
            }

            var viewModel = new EditPortfolioViewModel
            {
                Id = dto.Id,
                Title = dto.Title,
                ShortDescription = dto.ShortDescription,
                Picture = dto.Picture, 
                Url = dto.Url
            };

            return View(viewModel); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditPortfolioViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            string? pictureUrl = viewModel.Picture; 

            if (viewModel.Picture != null)
            {
                pictureUrl = $"/images/portfolio/{Guid.NewGuid()}{Path.GetExtension(viewModel.Picture)}";
            }

            var dto = new PortfolioDto
            {
                Id = viewModel.Id,
                Title = viewModel.Title,
                ShortDescription = viewModel.ShortDescription,
                Picture = pictureUrl, 
                Url = viewModel.Url
            };

            await _portfolioService.UpdatePortfolioAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var dto = await _portfolioService.GetPortfolioByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }
            await _portfolioService.DeletePortfolioAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
