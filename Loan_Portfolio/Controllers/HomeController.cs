using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Loan_Portfolio.Models;
using Loan_Portfolio.Controllers;
using System.Net;
using Newtonsoft.Json;
namespace Loan_Portfolio.Controllers
{
	public class HomeController : Controller
	{
		public string CodeText { get; set; }
		public HomeController() {
			CodeText = "why refuse";
		}
		public ActionResult Index()
		{
			if (ViewData["searchy"] != null)
			{
			}
			else {
				ViewData["searchy"]=null;
			}
			return View();

		}
		[Route("Mana")]
		public ActionResult Mana(DocDetail d)
		{
			ViewData["date"] = d.Date;

			return View();
		}
		[HttpPost]
		[ActionName("Index")]
		public ActionResult IndexPost(SearchModel s){
			string file = System.IO.File.ReadAllText(@"\path.json");
			List<DocDetail> frm = JsonConvert.DeserializeObject<List<DocDetail>>(file);
			ViewData["searchy"]= s.searcher;

			ViewBag.list = frm;
			ViewBag.date = DateTime.Now.ToShortDateString();
			ViewBag.app = s.approval;
			return View();
		}
	}
	}


