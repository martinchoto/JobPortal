using JobPortal.Core.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class Type
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(DataConstants.TYPE_NAME)]
		public string Name { get; set; } = null!;
	}
}
