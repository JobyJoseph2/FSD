using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Login()
        {
			ViewBag.IsAuthenticated = false;
			return View();
        }

		[HttpPost]
		public ActionResult Login(LoginViewModel model)
		{
			ViewBag.IsAuthenticated = false;
			return View();
		}

		public ActionResult Create()
		{
			return View();
		}
    }
}