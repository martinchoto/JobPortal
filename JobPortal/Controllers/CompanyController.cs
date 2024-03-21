using JobPortal.Core.Constants;
using JobPortal.Services.Company;
using JobPortal.ViewModels.Company;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Security.Claims;

namespace JobPortal.Controllers
{
    [Authorize(Roles = "Company")]
	public class CompanyController : Controller
	{
		private readonly ICompanyService _companyService;

		public CompanyController(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<IActionResult> All()
		{
			var offers = await _companyService.GetAllJobOffersForCompanyAsync(GetUserId());
			return View(offers);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var viewModel = new AddJobOfferViewModel
			{
				Types = await _companyService.GetTypes()
			};
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddJobOfferViewModel viewModel)
		{
			await _companyService.AddJobOfferAsync(viewModel, GetUserId());
			return RedirectToAction(nameof(All), "Company");
		}
		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var edited = await _companyService.GetOffer(id);
			if (edited == null)
			{
				return BadRequest();
			}
			if (edited.CompanyId != GetUserId())
			{
				return Unauthorized();
			}

			AddJobOfferViewModel viewModel = await _companyService.BuildEditViewModel(id);
			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Edit(AddJobOfferViewModel viewModel, int id)
		{
			var edited = await _companyService.GetOffer(id);
			if (edited == null)
			{
				return BadRequest();
			}
			if (edited.CompanyId != GetUserId())
			{
				return Unauthorized();
			}
			await _companyService.EditJobOfferAsync(viewModel, id, GetUserId());

			return RedirectToAction(nameof(All), "Company");
		}
		public async Task<IActionResult> Delete(int id)
		{
			var offer = await _companyService.GetOffer(id);
			if (offer == null)
			{
				return BadRequest();
			}
			if (offer.CompanyId != GetUserId())
			{
				return Unauthorized();
			}
			DeleteViewModel delViewModel = new DeleteViewModel()
			{
				Id = offer.Id,
				Position = offer.Position,
				Salary = offer.Salary.ToString(DataConstants.DECIMAL_FORMAT),
				LastUpdated = offer.PostedDate.ToString("yyyy-MM-dd")
			};
			return View(delViewModel);
		}
		public async Task<IActionResult> ConfirmDelete(int id)
		{
            var offer = await _companyService.GetOffer(id);
            if (offer == null)
            {
                return BadRequest();
            }
            if (offer.CompanyId != GetUserId())
            {
                return Unauthorized();
            }
			await _companyService.DeleteJobOffer(offer);
            return RedirectToAction(nameof(All), "Company");
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}

