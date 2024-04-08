using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging;
using Type = JobPortal.Core.Data.Models.Type;

namespace JobPortal.Core
{
	public class SeedData
	{
		//private readonly UserManager<AppUser> _userManager;

		public IEnumerable<Company> SeedCompanies()
		{
			var company = new Company()
			{
				Id = 1,
				UserId = "b5b0f315-98eb-4078-bf80-a329869ad392",
				Address = "ul. Aleksander Stamboliiski",
				Location = "Pazardjik",
				CompanyName = "Billa",
				LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Billa-Logo.svg/2560px-Billa-Logo.svg.png"
			};

			var secondCompany = new Company()
			{
				Id = 2,
				UserId = "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
				Address = "ul. Iordan Iosifov",
				Location = "Sofia",
				CompanyName = "Lidl",
				LogoUrl = "https://w7.pngwing.com/pngs/106/455/png-transparent-yellow-red-and-blue-lidl-logo-lidl-logo-retail-supermarket-toru%C5%84-lidl-food-text-business.png"

			};
			var thirdCompany = new Company()
			{
				Id = 3,
				UserId = "ca27630c-7fa9-4d54-b8f1-851252abc519",
				Address = "bul. Tsarigradsko Shose",
				Location = "Sofia",
				CompanyName = "Bosch",
				LogoUrl = "https://banner2.cleanpng.com/20180804/loj/kisspng-logo-robert-bosch-gmbh-alternator-product-electric-adelaide-laser-calibration-service-repair-amp-5b659ac12b5114.3730089015333854091774.jpg"
			};

			var companies = new Company[] { company, secondCompany, thirdCompany };

			return companies;
		}


		public IEnumerable<Type> SeedTypes()
		{
			Type[] types = new Type[] {
			new Type(){ Id = 1,Name = "Technical"},
			 new Type(){ Id = 2, Name = "Business"},
			 new Type(){ Id = 3, Name = "Healthcare"},
			 new Type(){  Id = 4, Name= "Creative"},
			 new Type(){ Id = 5, Name = "Education"},
			 new Type() {Id = 6, Name = "Customer Service"}
			};
			return types;
		}
		public  IEnumerable<AppUser> SeedUsers()
		{
			var hasher = new PasswordHasher<AppUser>();

			var adminUser = new AppUser()
			{
				Id = "11d42cfa-0eb5-4556-bbee-452d66efacf8",
				UserName = "admin",
				NormalizedUserName = "admin",
				Email = "martoadmin@abv.bg",
				NormalizedEmail = "martoadmin@abv.bg",
				FirstName = "Martin",
				LastName = "Stalev",
				CreatedOn = DateTime.Now
			};
			adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin");
			//await _userManager.AddToRoleAsync(adminUser, "Admin");

			var companyLidl = new AppUser()
			{
				Id = "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
				UserName = "lidlbg",
				NormalizedUserName = "LIDLBG",
				Email = "lidlbg@abv.bg",
				NormalizedEmail = "LIDLBG@ABV.BG",
				CreatedOn = DateTime.Now
			};
			companyLidl.PasswordHash = hasher.HashPassword(companyLidl, "asdasd");
			//await _userManager.AddToRoleAsync(companyLidl, "Company");

			var companyBosch = new AppUser()
			{
				Id = "ca27630c-7fa9-4d54-b8f1-851252abc519",
				UserName = "boschbg",
				NormalizedUserName = "BOSCHBG",
				Email = "boschbg@abv.bg",
				NormalizedEmail = "BOSCHBG@ABV.BG",
				CreatedOn = DateTime.Now
			};
			companyBosch.PasswordHash = hasher.HashPassword(companyBosch, "asdasd");
			//await _userManager.AddToRoleAsync(companyBosch, "Company");

			var applicant = new AppUser()
			{
				Id = "018bff8a-5df3-40d8-8a65-e6a5e932f957",
				UserName = "martinchoto",
				NormalizedUserName = "MARTINCHOTO",
				Email = "martoplays@abv.bg",
				NormalizedEmail = "MARTOPLAYS@ABV.BG",
				FirstName = "Martinkata",
				LastName = "Voivodov",
				CreatedOn = DateTime.Now
			};
			applicant.PasswordHash = hasher.HashPassword(applicant, "asdasd");
			//await _userManager.AddToRoleAsync(applicant, "Applicant");
			var users = new AppUser[] { adminUser, companyLidl, companyBosch, applicant };
			return users;
		}
	}
}