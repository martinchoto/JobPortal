// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using JobPortal.Core.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace JobPortal.Areas.Identity.Pages.Account
{
	public class RegisterCompany : PageModel
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;
		private readonly IUserStore<AppUser> _userStore;
		private readonly IUserEmailStore<AppUser> _emailStore;
		private readonly ILogger<RegisterCompany> _logger;
		private readonly IEmailSender _emailSender;
		private readonly JobPortalDbContext _dbContext;

		public RegisterCompany(
			UserManager<AppUser> userManager,
			IUserStore<AppUser> userStore,
			SignInManager<AppUser> signInManager,
			ILogger<RegisterCompany> logger,
			JobPortalDbContext context)
		{
			_userManager = userManager;
			_userStore = userStore;
			_emailStore = GetEmailStore();
			_signInManager = signInManager;
			_logger = logger;
			_dbContext = context;
		}

		/// <summary>
		///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
		///     directly from your code. This API may change or be removed in future releases.
		/// </summary>
		[BindProperty]
		public InputModel Input { get; set; }

		/// <summary>
		///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
		///     directly from your code. This API may change or be removed in future releases.
		/// </summary>
		public string ReturnUrl { get; set; }

		/// <summary>
		///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
		///     directly from your code. This API may change or be removed in future releases.
		/// </summary>
		public class InputModel
		{
			[Required]
			public string Username { get; set; }
			[Required]
			[EmailAddress]
			[Display(Name = "Email")]
			public string Email { get; set; }

			[Required]
			[Display(Name = "Company name")]
			public string CompanyName { get; set; }
			[Required]
			[Display(Name = "Address")]
			public string Address { get; set; }
			[Required]
			public string Location { get; set; }
			[Required]
			public string LogoUrl { get; set; }

			[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
			[DataType(DataType.Password)]
			[Display(Name = "Password")]
			public string Password { get; set; }


			[DataType(DataType.Password)]
			[Display(Name = "Confirm password")]
			[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
			public string ConfirmPassword { get; set; }
		}


		public async Task<IActionResult> OnGetAsync(string returnUrl = null)
		{
			if (User.Identity.IsAuthenticated && User.Identity != null)
			{
				return RedirectToAction("Index", "Home");
			}
			ReturnUrl = returnUrl;
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(string returnUrl = null)
		{
			returnUrl ??= Url.Content("~/");

			if (ModelState.IsValid)
			{
				var user = CreateUser();
				user.CreatedOn = DateTime.Now;
				await _userStore.SetUserNameAsync(user, Input.Username, CancellationToken.None);
				await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
				var result = await _userManager.CreateAsync(user, Input.Password);

				if (result.Succeeded)
				{
					_logger.LogInformation("User created a new account with password.");

					Company company = new Company()
					{
						CompanyName = Input.CompanyName,
						LogoUrl = Input.LogoUrl,
						Location = Input.Location,
						Address = Input.Address,
						UserId = user.Id
					};
					await _userManager.AddToRoleAsync(user, "Company");

					await _dbContext.Companies.AddAsync(company);
					await _dbContext.SaveChangesAsync();
					return LocalRedirect(returnUrl);

				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}

			// If we got this far, something failed, redisplay form
			return Page();
		}

		private AppUser CreateUser()
		{
			try
			{
				return Activator.CreateInstance<AppUser>();
			}
			catch
			{
				throw new InvalidOperationException($"Can't create an instance of '{nameof(AppUser)}'. " +
					$"Ensure that '{nameof(AppUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
					$"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
			}
		}

		private IUserEmailStore<AppUser> GetEmailStore()
		{
			if (!_userManager.SupportsUserEmail)
			{
				throw new NotSupportedException("The default UI requires a user store with email support.");
			}
			return (IUserEmailStore<AppUser>)_userStore;
		}
	}
}
