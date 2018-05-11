using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class LanguagesController : Controller
    {
		// GET: Languages
		[HttpGet]

		public ActionResult Index()
        {
			var languagesList = new List<languages>{
							new languages () { languages_Id =1515 , languages_Name= "Arabic" ,prices = 25},
							new languages () { languages_Id =1414 , languages_Name= "English" ,prices = 40},
							new languages () { languages_Id =1875 , languages_Name= "French" ,prices = 20},
							new languages () { languages_Id =1978 , languages_Name= "Turki" ,prices = 45},
							new languages () { languages_Id =1441 , languages_Name= "German" ,prices = 60},


						};
			return View(languagesList);
        }

		[HttpPost]
		public ActionResult Index(int languages_Id, string languages_Name, decimal prices)
		{
			ViewBag.languages_Name = languages_Name;

			return View("Confirm");
		}

		[HttpPost]
		public ActionResult IndexNew(languages lang)
		{

			return View("ConfirmNew", lang);
		}


		public ActionResult Create()
		{
			return View();
		}

		public ActionResult CreateNew()
		{
			return View();
		}

		public ActionResult Details()
		{
			return Details();
		}

		public ActionResult Delete()
		{
			return Delete();
		} 
		public ActionResult Edit()
		{
			return Edit();
		}
	}
}
