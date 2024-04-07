using System.ComponentModel.DataAnnotations;

namespace JobPortal.Extensions.Attributes
{
	public class IsBefore : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			return base.IsValid(value, validationContext);
		}
	}
}
