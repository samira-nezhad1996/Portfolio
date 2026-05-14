using Application.DataTransferObject;
using Application.Services.MyServices;
using Application.ViewModels.MyService;
using Microsoft.AspNetCore.Mvc;

namespace web.Areas.Admin.Controllers
{
    public class MyServiceController : AdminBaseController
    {
        private readonly IMyServiceService _myServiceService;

        public MyServiceController(IMyServiceService myServiceService)
        {
            _myServiceService = myServiceService;
        }

        public async Task<IActionResult> Index()
        {
            var dtos = await _myServiceService.GetAllServicesAsync();

            var viewModels = dtos.Select(dto => new MyServiceViewModel
            {
                Id = dto.Id,
                Title = dto.Title,
                Logo = dto.Logo 
            }).ToList();

            return View(viewModels);
        }

        public IActionResult Create()
        {
            return View(new CreateMyServiceViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMyServiceViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var dto = new MyServicesDto
            {
                Title = viewModel.Title,
                Logo = viewModel.Logo,
            };
            await _myServiceService.InsertMyServiceAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var dto = await _myServiceService.GetMyServiceByIdAsync(id);

            if (dto == null)
            {
                return NotFound();
            }

            var viewModel = new EditMyServiceViewModel
            {
                Id = dto.Id,
                Title = dto.Title,
                Logo = dto.Logo,
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditMyServiceViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var dto = new MyServicesDto
            {
                Id = viewModel.Id, 
                Title = viewModel.Title,
                Logo = viewModel.Logo,
            };

            await _myServiceService.UpdateMyServiceAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _myServiceService.DeleteMyServiceAsync(id);
            }
            catch (KeyNotFoundException)
            {
 
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
