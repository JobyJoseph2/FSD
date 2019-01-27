using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POWebAPI.Models
{
	public class POMasterFullViewModel
	{
		public int PONO;
		public DateTime PODate;

		public List<PODetailsViewModel> PODetails = new List<PODetailsViewModel>();
		public SupplierViewModel supplier = new SupplierViewModel();
		
	


	}
}