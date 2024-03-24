namespace JobPortal.ViewModels.Company
{
    public class AllMyJobOffers
    {
        public int Id { get; set; }
        public string Status { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Salary { get; set; } = null!;
        public int VacationDays { get; set; }
        public string Type { get; set; } = null!;
    }
}
