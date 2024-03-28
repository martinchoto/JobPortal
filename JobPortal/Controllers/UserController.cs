using JobPortal.Core.Data.Identity;
using JobPortal.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortal.Controllers
{
	[AllowAnonymous]
	public class UserController : Controller
	{
		private readonly UserManager<AppUser> userManager;

		private readonly SignInManager<AppUser> signInManager;

		public UserController(
			UserManager<AppUser> _userManager,
			SignInManager<AppUser> _signInManager)
		{
			userManager = _userManager;
			signInManager = _signInManager;
		}
		[HttpGet]
		public async Task<IActionResult> Login()
		{
			if (User.Identity.IsAuthenticated && User.Identity != null)
			{
				return RedirectToAction("Index", "Home");
			}
			LoginViewModel loginViewModel = new LoginViewModel();

			return View(loginViewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				return View(viewModel);
			}

			var user = await userManager.FindByNameAsync(viewModel.UserName);

			if (user != null)
			{
				var result = await signInManager.PasswordSignInAsync(user, viewModel.Password, 
					true, 
					false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
			}
			ModelState.AddModelError("", "Invalid login");
			return View(viewModel);
		}
	}
}
