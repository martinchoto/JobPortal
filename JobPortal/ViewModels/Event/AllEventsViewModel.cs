namespace JobPortal.ViewModels.Event
{
	public class AllEventsViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Date { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string OwnerId { get; set; } = null!;
		public string CompanyName { get; set; } = null!;
		public string GetInfo()
		{
			Name = Name.Replace(" ", "-").ToLower().Trim();
			CompanyName = CompanyName.Replace(" ", "-").ToLower().Trim();
			return $"{Name}-{CompanyName}";
		}
	}
}
