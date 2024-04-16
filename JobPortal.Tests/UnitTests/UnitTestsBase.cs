using JobPortal.Core.Data;
using JobPortal.Tests.Mocks;
using JobPortal.Core;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Core.Data.Identity;
using Microsoft.AspNetCore.Identity;

namespace JobPortal.Tests.UnitTests
{
	public class UnitTestsBase
	{
		protected JobPortalDbContext _context;
		[OneTimeSetUp]
		public void SetUpBase()
		{
			_context = DatabaseMocks.Instance;
			SeedData seedData = new SeedData();
			_context.Types.AddRange(seedData.SeedTypes());
			_context.Users.AddRange(seedData.SeedUsers());
			_context.Roles.AddRange(seedData.SeedRoles());
			_context.UserRoles.AddRange(seedData.SeedUserRoles());
			_context.Companies.AddRange(seedData.SeedCompanies());
			_context.Events.AddRange(seedData.SeedEvent());
			_context.Applications.AddRange(seedData.SeedApplications());
			_context.JobOffers.AddRange(seedData.SeedOffers());
			_context.SaveChanges();
		}
		[OneTimeTearDown]
		public void TearDownBase()
		{
			_context.Dispose();
		}
	}
}
