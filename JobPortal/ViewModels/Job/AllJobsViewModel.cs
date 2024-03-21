namespace JobPortal.ViewModels.Job
{
    public class AllJobsViewModel
    {
		public int Id { get; set; }
		public string Status { get; set; } = null!;
		public string Position { get; set; } = null!;
		public string Salary { get; set; } = null!;
		public int VacationDays { get; set; }
		public string ImageUrl { get; set; } = null!;
	}
}
