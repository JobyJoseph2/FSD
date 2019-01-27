using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
	public class LoginViewModel
	{
		[Display(Name ="User Name")]
		public string  UserName { get; set; }

		public string Password { get; set; }
	}
}