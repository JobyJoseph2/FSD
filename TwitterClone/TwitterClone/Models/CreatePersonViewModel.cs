using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
	public class CreatePersonViewModel
	{
		[Display(Name ="User ID")]
		public string user_id { get; set; }
		[Display(Name ="Password")]
		public string password { get; set; }
		[Display(Name ="Full Name")]
		public string fullName { get; set; }
		[Display(Name ="Email")]
		public string email { get; set; }
		public System.DateTime joined { get; set; }
		public bool active { get; set; }
	}
}