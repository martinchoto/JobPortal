using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Type = JobPortal.Core.Data.Models.Type;

namespace JobPortal.Core
{
	public class SeedData
	{
		public Company FirstCompany = new Company()
		{
			Id = 1,
			UserId = "b5b0f315-98eb-4078-bf80-a329869ad392",
			Address = "ul. Aleksander Stamboliiski",
			Location = "Pazardjik",
			CompanyName = "Billa",
			LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Billa-Logo.svg/2560px-Billa-Logo.svg.png"
		};

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
		public AppUser SeedUsers()
		{
			var hasher = new PasswordHasher<AppUser>();

			var adminUser = new AppUser()
			{
				Id = "68d6168e-4e02-4521-b6ea-8c4cb3e792c7",
				UserName = "admin",
				NormalizedUserName = "admin",
				Email = "martoadmin@abv.bg",
				NormalizedEmail = "martoadmin@abv.bg",
				FirstName = "Martin",
				LastName = "Stalev",
				CreatedOn = DateTime.Now
			};
			adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin");


			return adminUser;
		}
	}
}