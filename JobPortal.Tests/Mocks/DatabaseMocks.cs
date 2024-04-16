using JobPortal.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Tests.Mocks
{
	public class DatabaseMocks
	{
		public static JobPortalDbContext Instance
		{
			get
			{
				var dbOptionsContext = new DbContextOptionsBuilder<JobPortalDbContext>()
					.UseInMemoryDatabase("JobPortalInMemoryDb" + DateTime.Now.Ticks.ToString())
					.Options;

				return new JobPortalDbContext(dbOptionsContext, false);
			}
		}
	}
}
