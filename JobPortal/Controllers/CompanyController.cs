using JobPortal.Core.Constants;
using JobPortal.Core.Data.Models;
using JobPortal.Services.Company;
using JobPortal.ViewModels.Application;
using JobPortal.ViewModels.Company;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobPortal.Controllers
{
	[Authorize(Roles = "Company,Admin")]
	public class CompanyController : Controller
	{
		private readonly ICompanyService _companyService;

		public CompanyController(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<IActionResult> All()
		{
			List<AllMyJobOffers> offers = await _companyService.GetAllJobOffersForCompanyAsync(GetUserId());
			return View(offers);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			AddJobOfferViewModel viewModel = new AddJobOfferViewModel
			{
				Types = await _companyService.GetTypes()
			};
			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddJobOfferViewModel viewModel)
		{
			Company company = await _companyService.CompanyAsync(GetUserId());
			if (company == null)
			{
				return BadRequest();
			}
            if (!ModelState.IsValid)
            {
                return View(viewModel);

            }
            await _companyService.AddJobOfferAsync(viewModel, company.Id);
			return RedirectToAction(nameof(All), "Company");
		}
		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			JobOffer edited = await _companyService.GetOffer(id);
			if (edited == null)
			{
				return BadRequest();
			}
			if (edited.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
			AddJobOfferViewModel viewModel = await _companyService.BuildEditViewModel(id);
			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Edit(AddJobOfferViewModel viewModel, int id)
		{
			JobOffer edited = await _companyService.GetOffer(id);
			if (edited == null)
			{
				return BadRequest();
			}
			if (edited.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
            if (!ModelState.IsValid)
            {
				viewModel.Types = await _companyService.GetTypes();
                return View(viewModel);
            }
            await _companyService.EditJobOfferAsync(viewModel, id);
			if (User.IsInRole("Admin"))
			{
				return RedirectToAction("Details", "Job", new {id = id});
			}
			return RedirectToAction(nameof(All), "Company");
		}
		public async Task<IActionResult> Delete(int id)
		{
			JobOffer offer = await _companyService.GetOffer(id);
			if (offer == null)
			{
				return BadRequest();
			}
			if (offer.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
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
			JobOffer offer = await _companyService.GetOffer(id);
			if (offer == null)
			{
				return BadRequest();
			}
			if (offer.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
			await _companyService.DeleteJobOffer(offer);
			if (User.IsInRole("Admin"))
			{
				return RedirectToAction("All", "Job");
			}
			return RedirectToAction(nameof(All), "Company");
		}
		public async Task<IActionResult> Applicants(int id)
		{
			JobOffer jobOffer = await _companyService.GetOffer(id);
			if (jobOffer == null)
			{
				return BadRequest();
			}
			if (jobOffer.Company.UserId != GetUserId())
			{
				return Unauthorized();
			}
			List<MyJobApplicationViewModel> model = await _companyService.GetAllApplicationsForJobOffers(jobOffer.Id);
			return View(model);
		}
		public async Task<IActionResult> DeleteApplication(int applicationId, int jobId)
		{
			JobOfferApplication toBeDeleted = await _companyService.GetJobOfferApplication(applicationId, jobId);
			if (toBeDeleted == null)
			{
				return BadRequest();
			}
			if (toBeDeleted.JobOffer.Company.UserId != GetUserId())
			{
				return Unauthorized();
			}
			await _companyService.DeleteApplication(toBeDeleted);
			return RedirectToAction("All", "Company");
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}

