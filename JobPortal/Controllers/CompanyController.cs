﻿using JobPortal.Core.Constants;
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
			var company = await _companyService.CompanyAsync(GetUserId());
			if (company == null)
			{
				return BadRequest();
			}
			await _companyService.AddJobOfferAsync(viewModel, company.Id);
			return RedirectToAction(nameof(All), "Company");
		}
		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var edited = await _companyService.GetOffer(id);
			if (edited == null || !User.IsInRole("Company"))
			{
				return BadRequest();
			}
			if (edited.Company.UserId != GetUserId())
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
			if (edited == null || !User.IsInRole("Company"))
			{
				return BadRequest();
			}
			if (edited.Company.UserId != GetUserId())
			{
				return Unauthorized();
			}
			await _companyService.EditJobOfferAsync(viewModel, id);

			return RedirectToAction(nameof(All), "Company");
		}
		public async Task<IActionResult> Delete(int id)
		{
			var offer = await _companyService.GetOffer(id);
			if (offer == null || !User.IsInRole("Company"))
			{
				return BadRequest();
			}
			if (offer.Company.UserId != GetUserId())
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
            if (offer == null || !User.IsInRole("Company"))
            {
                return BadRequest();
            }
            if (offer.Company.UserId != GetUserId())
            {
                return Unauthorized();
            }
			await _companyService.DeleteJobOffer(offer);
            return RedirectToAction(nameof(All), "Company");
		}
		public async Task<IActionResult> Applicants(int id)
		{
			var model = await _companyService.GetAllApplicationsForJobOffers(id);
			return View(model);
		}
		public async Task<IActionResult> DeleteApplication(int id)
		{
			var toBeDeleted = await _companyService.GetApplicationById(id);
			if (toBeDeleted == null)
			{
			  return BadRequest();
			}
			await _companyService.DeleteApplication(toBeDeleted);
			return RedirectToAction("All", "Company");
		}
		public async Task<IActionResult> Details(int id)
		{
			var jobApplication = await _companyService.GetApplicationById(id);
			if (jobApplication == null)
            {
				return BadRequest();
            }
			var model = await _companyService.DetailsBuildViewModel(jobApplication);
            return View(model);
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}

