namespace JobPortal.ViewModels.Job
{
	public class AllCompaniesViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string GetInfo()
		{
			Name = Name.Replace(" ", "-").ToLower();
			return $"{Name}";
		}
	}
}
