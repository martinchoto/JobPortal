using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using Type = JobPortal.Core.Data.Models.Type;

namespace JobPortal.Core
{
	public class SeedData
	{
		internal IEnumerable<Company> SeedCompanies()
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
				LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Lidl-Logo.svg/150px-Lidl-Logo.svg.png"

			};
			var thirdCompany = new Company()
			{
				Id = 3,
				UserId = "ca27630c-7fa9-4d54-b8f1-851252abc519",
				Address = "bul. Tsarigradsko Shose",
				Location = "Sofia",
				CompanyName = "Bosch",
				LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Bosch-logo.svg/1920px-Bosch-logo.svg.png"
			};

			var companies = new Company[] { company, secondCompany, thirdCompany };

			return companies;
		}
		internal IEnumerable<Type> SeedTypes()
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
		internal IEnumerable<AppUser> SeedUsers()
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
			var users = new AppUser[] { adminUser, companyLidl, companyBosch, applicant };
			return users;
		}
		internal IEnumerable<Event> SeedEvent()
		{
			Event event1 = new Event()
			{
				Id = 1,
				Name = "Eating Contest",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				CompanyId = 1,
				Date = DateTime.Now.AddDays(60),
				ImageUrl = "https://espnpressroom.com/us/files/2023/06/Hot-Dog-Eating-Contest.png"
			};
			Event event2 = new Event()
			{
				Id = 2,
				CompanyId = 1,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Name = "Shooting",
				Date = DateTime.Now.AddDays(40),
				ImageUrl = "https://img.olympics.com/images/image/private/t_s_pog_staticContent_hero_sm/f_auto/primary/qpudtgofz5sw2ffcpz4j"
			};
			Event event3 = new Event()
			{
				Id = 3,
				CompanyId = 2,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Name = "Day of the open doors",
				Date = DateTime.Now.AddDays(20),
				ImageUrl = "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg"
			};
			Event event4 = new Event()
			{
				Id = 4,
				CompanyId = 2,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Name = "Reading",
				Date = DateTime.Now.AddDays(20),
				ImageUrl = "https://post.healthline.com/wp-content/uploads/2021/09/reading-book-1296x728-header.jpg"
			};
			Event event5 = new Event()
			{
				Id = 5,
				CompanyId = 3,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Name = "Day of the open doors",
				ImageUrl = "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg",
				Date = DateTime.Now.AddDays(4)
			};
			Event event6 = new Event()
			{
				Id = 6,
				CompanyId = 3,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Name = "Programming course",
				Date = DateTime.Now.AddDays(45),
				ImageUrl = "https://www.classcentral.com/report/wp-content/uploads/2022/03/Frame-3.png"
			};

			Event[] events = new Event[] { event1, event2, event3, event4, event5, event6 };
			return events;
		}
		internal IEnumerable<JobApplication> SeedApplications()
		{
			JobApplication jobApplication1 = new JobApplication()
			{
				Id = 1,
				Name = "Application for Cashier",
				CreatedOn = DateTime.Now,
				FullName = "Martin Stalev",
				Email = "martoplays@abv.bg",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.",
				UserId = "018bff8a-5df3-40d8-8a65-e6a5e932f957",
				Reason = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor."

			};
			JobApplication jobApplication2 = new JobApplication()
			{
				Id = 2,
				Name = "Application for Web Dev",
				CreatedOn = DateTime.Now,
				FullName = "Martin Stalev",
				Email = "martoplays@abv.bg",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.",
				UserId = "018bff8a-5df3-40d8-8a65-e6a5e932f957",
				Reason = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor."
			};

			JobApplication[] applications = new JobApplication[] { jobApplication1, jobApplication2 };
			return applications;
			
		}
		internal IEnumerable<JobOffer> SeedOffers()
		{
			JobOffer offer1 = new JobOffer()
			{
				Id = 1,
				Status = "fulltime 8hrs/day",
				Position = "Warehouse worker",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Salary = 1000M,
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-333),
				VacationDays = 22,
				TypeId = 1,
				CompanyId = 1

			};
			JobOffer offer2 = new JobOffer()
			{
				Id = 2,
				Status = "fulltime 8hrs/day",
				Position = "Cashier",
				Salary = 1200M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-333),
				VacationDays = 22,
				TypeId = 6,
				CompanyId = 1
			};
			JobOffer offer3 = new JobOffer()
			{
				Id = 3,
				Status = "fulltime 8hrs/day",
				Position = "Cleaner",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-333),
				VacationDays = 22,
				TypeId = 6,
				CompanyId = 1
			};
			JobOffer offer4 = new JobOffer()
			{
				Id = 4,
				Status = "fulltime 8hrs/day",
				Position = "Cashier",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-33),
				VacationDays = 22,
				TypeId = 6,
				CompanyId = 2
			};
			JobOffer offer5 = new JobOffer()
			{
				Id = 5,
				Status = "fulltime 8hrs/day",
				Position = "Cleaner for tiles",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-33),
				VacationDays = 22,
				TypeId = 6,
				CompanyId = 2
			};
			JobOffer offer6 = new JobOffer()
			{
				Id = 6,
				Status = "fulltime 8hrs/day",
				Position = "Cleaner for toilets",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-33),
				VacationDays = 22,
				TypeId = 6,
				CompanyId = 2
			};
			JobOffer offer7 = new JobOffer()
			{
				Id = 7,
				Status = "fulltime 8hrs/day",
				Position = "Web Designer",
				Salary = 2200M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-3),
				VacationDays = 32,
				TypeId = 1,
				CompanyId = 3
			};
			JobOffer offer8 = new JobOffer()
			{
				Id = 8,
				Status = "fulltime 8hrs/day",
				Position = "Web Eng",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-3),
				VacationDays = 32,
				TypeId = 1,
				CompanyId = 3
			};
			JobOffer offer9 = new JobOffer()
			{
				Id = 9,
				Status = "fulltime 4hrs/day intern",
				Position = "Web Dev",
				Salary = 1400M,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n",
				Bonus = "Whole a lot of benefits working for a big company",
				PostedDate = DateTime.Now.AddDays(-3),
				VacationDays = 30,
				TypeId = 1,
				CompanyId = 3
			};

			JobOffer[] offers = new JobOffer[] { offer1, offer2, offer3, offer4, offer5, offer6, offer7, offer8, offer9 };

			return offers;
		}
	}
}