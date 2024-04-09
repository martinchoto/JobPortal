namespace JobPortal.ViewModels.Job
{
    public class JobOffersViewModel
    {
		public int Id { get; set; }
		public string Status { get; set; } = null!;
		public string Position { get; set; } = null!;
		public string Salary { get; set; } = null!;
		public int VacationDays { get; set; }
		public string ImageUrl { get; set; } = null!;
		public string Type { get; set; } = null!;
		public string CompanyName { get; set; } = null!;
		public string GetInformation()
		{
			Position = Position.Replace(" ", "-").ToLower().Trim();
			CompanyName = CompanyName.Replace(" ", "-").ToLower().Trim();
			Type = Type.Replace(" ", "-").ToLower().Trim();
			return $"{CompanyName}-{Position}-{Type}";
		}
	}
}
