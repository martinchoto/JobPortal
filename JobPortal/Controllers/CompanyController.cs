using Job_Portal.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Services.Company;
using JobPortal.ViewModels.Company;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Xml.Linq;

namespace JobPortal.Controllers
{
	[Authorize(Roles = "Company")]
	public class CompanyController : Controller
	{
		private readonly ICompanyService _companyService;
		private readonly JobPortalDbContext _dbContext;

		public CompanyController(ICompanyService companyService, JobPortalDbContext data)
		{
			_companyService = companyService;
			_dbContext = data;
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
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}

