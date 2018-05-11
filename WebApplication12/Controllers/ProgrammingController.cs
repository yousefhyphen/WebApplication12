using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class ProgrammingController : Controller
    {
		// GET: Programming
		[HttpGet]

		public ActionResult Index()
        {
			var Programminglist = new List<Programming>{
							new Programming () { Programming_Id =1 , Programming_Name= "c#" ,Prices = 25},
							new Programming () { Programming_Id =2 , Programming_Name= "java" ,Prices = 40},
							new Programming () { Programming_Id =3 , Programming_Name= "css" ,Prices = 20},
							new Programming () { Programming_Id =4 , Programming_Name= "ASP.NET" ,Prices = 45},
							new Programming () { Programming_Id =5 , Programming_Name= "SQL" ,Prices = 60},


						};
			return View(Programminglist);
		}

		[HttpPost]
		public ActionResult Index(int Programming_Id, string Programming_Name, decimal prices)
		{
			ViewBag.Programming_Name = Programming_Name;

			return View("Confirm");
		}

		[HttpPost]
		public ActionResult IndexNew(Programming Programming)
		{

			return View("ConfirmNew", Programming);
		}


		public ActionResult Create()
		{
			return View();
		}

		public ActionResult CreateNew()
		{
			return View();
		}

	}
}