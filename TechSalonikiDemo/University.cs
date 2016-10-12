using System;
namespace TechSalonikiDemo
{
	public class University
	{
		public string web_page { get; set; }
		public string country { get; set; }
		public string domain { get; set; }
		public string name { get; set; }
		private string _alpha_two_code;
		public string alpha_two_code 
		{
			get { return _alpha_two_code;}
			set { _alpha_two_code = String.Format(@"https://github.com/stevenrskelton/flag-icon/blob/master/png/75/country-squared/{0}.png?raw=true",value.ToLower()); }
		}

	}
}
