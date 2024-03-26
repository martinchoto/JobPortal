using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Models
{
	public class JobOfferApplication
	{
		[ForeignKey(nameof(JobOffer))]
		public int JobOfferId { get; set; }
		public virtual JobOffer JobOffer { get; set; } = null!;
        [ForeignKey(nameof(Application))]
        public int ApplicationId { get; set; }
		public virtual JobApplication Application { get; set; } = null!;
	}
}
