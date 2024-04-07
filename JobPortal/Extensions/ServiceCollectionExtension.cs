using JobPortal.Core.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Services.Application;
using JobPortal.Services.Company;
using JobPortal.Services.Event;
using JobPortal.Services.Job;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Extensions
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			return services;
		}

		public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection");
			services.AddDbContext<JobPortalDbContext>(options =>
				options.UseSqlServer(connectionString));

			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}

		public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
		{
			services
				.AddIdentity<AppUser, IdentityRole>(options =>
				{
					options.SignIn.RequireConfirmedEmail = false;
					options.Password.RequireDigit = false;
					options.Password.RequireNonAlphanumeric = false;
					options.Password.RequireUppercase = false;
				})
					.AddRoles<IdentityRole>()
					.AddEntityFrameworkStores<JobPortalDbContext>();

			return services;
		}
		public static IServiceCollection AddBussinessServices(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<IJobService, JobService>();
			services.AddScoped<IApplicationService, ApplicationService>();
			services.AddScoped<IEventService, EventService>();
			return services;
		}
	}
}