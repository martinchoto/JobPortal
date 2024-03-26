namespace JobPortal.ViewModels.Job
{
	public class JobDetailsViewModel
	{
		public int Id { get; set; }
		public string Status { get; set; } = null!;
		public string Position { get; set; } = null!;
		public string Bonus { get; set; } = null!;
		public string Salary { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int VacationDays { get; set; } 
		public string CompanyId { get; set; } = null!;
		public string LastUpdatedOn { get; set; } = null!;
		public string CompanyName { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Location { get; set; } = null!;
		public string Address { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string Type { get; set; } = null!;
		public List<AllApplicationsViewModel> Applications { get; set; } = new List<AllApplicationsViewModel>();
	}
}
