using Job_Portal.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.ViewModels;
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
		private readonly JobPortalDbContext context;
		public CompanyController(JobPortalDbContext _context)
		{
			context = _context;
		}
		public async Task<IActionResult> All()
		{
			var offers = await context
				.JobOffers
				.Where(x  => x.UserId == GetUserId())
				.Select(x => new AllMyJobOffers
				{
					Id = x.Id,
					Status = x.Status,
					VacationDays = x.VacationDays,
					Position = x.Position,
					Salary = x.Salary.ToString("0.##"),
				}).ToListAsync();
			return View(offers);
		}
		[HttpGet]
		public IActionResult Add()
		{
			AddJobOfferViewModel viewModel = new AddJobOfferViewModel()
			{
				Types = GetTypes()
			};
			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Add(AddJobOfferViewModel viewModel)
		{
			JobOffer jobOffer = new JobOffer()
			{
				Position = viewModel.Position,
				Status = viewModel.Status,
				Description = viewModel.Description,
				Bonus = viewModel.Bonus,
				Salary = viewModel.Salary,
				VacationDays = viewModel.VacationDays,
				TypeId = viewModel.TypeId,
				UserId = GetUserId(),
				PostedDate = DateTime.UtcNow
			};

			await context.JobOffers.AddAsync(jobOffer);
			await context.SaveChangesAsync();
			return RedirectToAction(nameof(All), "Company");
		}
		public List<TypesViewModel> GetTypes()
		{
			return context.Types
				.Select(x => new TypesViewModel
				{
					Id = x.Id,
					Name = x.Name,
				})
				.ToList();
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}
