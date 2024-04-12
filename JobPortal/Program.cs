using JobPortal.Extensions.ServiceCollections;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);

builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddBussinessServices(builder.Configuration);

builder.Services.AddCors();

builder.Services.AddMvc(options =>
 options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}


app.UseExceptionHandler("/Home/Error/500");
app.UseStatusCodePagesWithRedirects("/Home/Error?statuscode={0}");
app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "Details",
		pattern: "/{controller}/Details/{id}/{info}",
		defaults: new { Action = "Details" });

	endpoints.MapControllerRoute(
		name: "All Offers",
		pattern: "/Job/AllOffers/{id}/{info}",
		defaults: new { Controller = "Job", Action = "AllOffers" });

	endpoints.MapDefaultControllerRoute();
	endpoints.MapRazorPages();
});


app.Run();
