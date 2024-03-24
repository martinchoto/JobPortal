using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Type = JobPortal.Core.Data.Models.Type;

namespace Job_Portal.Data
{
    public class JobPortalDbContext : IdentityDbContext<AppUser>
	{
		private readonly SeedData seedData;

		public JobPortalDbContext(DbContextOptions<JobPortalDbContext> options)
			: base(options)
		{
			seedData = new SeedData();
		}
		public DbSet<Company> Companies { get; set; } = null!;
		public DbSet<JobOffer> JobOffers { get; set; } = null!;
		public DbSet<Type> Types { get; set; } = null!;
		public DbSet<Application> Applications { get; set; } = null!;
		public DbSet<JobOfferApplication> JobOffersApplications { get; set; } = null!;
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseLazyLoadingProxies();
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Type>()
				.HasData(seedData.SeedTypes());

			builder.Entity<JobOfferApplication>()
				.HasKey(pk => new {pk.JobOfferId, pk.ApplicationId});

			builder.Entity<JobOfferApplication>()
				.HasOne(jo => jo.JobOffer)
				.WithMany(jo => jo.JobOfferApplications)
				.HasForeignKey(fk => fk.JobOfferId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<JobOfferApplication>()
				.HasOne(a => a.Application)
				.WithMany(jo => jo.JobOfferApplications)
				.HasForeignKey(fk => fk.ApplicationId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
