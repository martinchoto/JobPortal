namespace JobPortal.ViewModels.Event
{
	public class EventDetailsViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string DateTime { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string CompanyName { get; set; } = null!;
		public string Location { get; set; } = null!;
		public string Address { get; set; } = null!;
	}
}
