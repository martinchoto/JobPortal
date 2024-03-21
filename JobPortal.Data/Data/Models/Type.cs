using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class Type
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(25)]
		public string Name { get; set; } = null!;
    }
}
