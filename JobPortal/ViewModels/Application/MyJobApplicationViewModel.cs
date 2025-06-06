﻿namespace JobPortal.ViewModels.Application
{
	public class MyJobApplicationViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string CreatedOn { get; set; } = null!;
		public int JobId { get; set; }
		public string GetInfo()
		{
			Name = Name.Replace(" ","-").ToLower().Trim();
			return Name;
		}
	}
}
