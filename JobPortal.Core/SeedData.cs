using JobPortal.Core.Data.Models;
using Type = JobPortal.Core.Data.Models.Type;

namespace JobPortal.Core
{
	public class SeedData
	{
		public Company FirstCompany = new Company()
		{
            Id = 1,
            UserId = "b5b0f315-98eb-4078-bf80-a329869ad392",
            Address = "ul. Aleksander Stamboliiski",
            Location = "Pazardjik",
            CompanyName = "Billa",
            LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Billa-Logo.svg/2560px-Billa-Logo.svg.png"
        };

		public IEnumerable<Type> SeedTypes()
		{
			Type[] types = new Type[] {
			new Type(){ Id = 1,Name = "Technical"},
			 new Type(){ Id = 2, Name = "Business"},
			 new Type(){ Id = 3, Name = "Healthcare"},
			 new Type(){  Id = 4, Name= "Creative"},
			 new Type(){ Id = 5, Name = "Education"},
			 new Type() {Id = 6, Name = "Customer Service"}
			};
			return types;
		}
	}
}