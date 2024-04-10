using JobPortal.Core.Enums;
using JobPortal.Services.Job.Models;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Job
{
    public class AllJobsQueryViewModel
	{
		public string Type { get; set; } = null!;
		[Display(Name = "Search by text")]
		public string SearchTerm { get; set; } = null!;
		[Display(Name = "Sorting")]
		public JobSorting JobSorting { get; set; }
		[Display(Name = "Jobs per page")]
		public int JobsPerPage { get; set; } 
		public int CurrentPage { get; set; } = 1;
		public int TotalJobsCount { get; set; }
		public List<string> Types { get; set; } = null!;

		public List<JobServiceModel> Jobs { get; set; } = new List<JobServiceModel>();
	}
}
