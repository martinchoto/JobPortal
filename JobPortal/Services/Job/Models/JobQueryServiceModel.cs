namespace JobPortal.Services.Job.Models
{
	public class JobQueryServiceModel
	{
		public int TotalJobsCount { get; set; }
		public List<JobServiceModel> Jobs { get; set; } = new List<JobServiceModel>();
	}
}
