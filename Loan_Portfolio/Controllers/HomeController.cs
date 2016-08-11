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
		public SearchModel m;

		public string CodeText { get; set; }
		public HomeController() {
			CodeText = "why refuse";
			m = new SearchModel();
			m.approval = "All";
			m.groups = "In Group";
			m.numpage = 20;
			m.searcher = null;
		}
		[HttpGet]
		public ActionResult Index(string numby,string app, string grp, string srch) {
			if (app != null) { m.approval = app; }
			if (grp != null) { m.groups = grp; }
			if (srch != null) { m.searcher = srch; }
			if (numby != null) { m.numpage = Convert.ToInt32(numby); }
			ViewData["Mod"] = m;
			ViewData["searchy"] = m.searcher;
			string file = System.IO.File.ReadAllText(@"\path.json");
			List<DocDetail> frm = JsonConvert.DeserializeObject<List<DocDetail>>(file);
			ViewBag.list = frm;	
			ViewBag.app = m.approval;

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
		public ActionResult IndexPost(SearchModel s)
		{
			string file = System.IO.File.ReadAllText(@"\path.json");
			List<DocDetail> frm = JsonConvert.DeserializeObject<List<DocDetail>>(file);
		
			m = s;
			ViewData["Mod"] = m;
			ViewData["searchy"] = m.searcher;
			ViewBag.list = frm;
			ViewBag.date = DateTime.Now.ToShortDateString();
			ViewBag.app = s.approval;
			return View();
		}
		[Route("Duplicate")]
		public ActionResult Duplicate(int idNum,string searcher,string approval,int numpage,string groups) {
			string file = System.IO.File.ReadAllText(@"\path.json");
			List<DocDetail> frm = JsonConvert.DeserializeObject<List<DocDetail>>(file);
			frm.Add(frm[idNum]);
			string json = JsonConvert.SerializeObject(frm);
			System.IO.File.WriteAllText(@"\path.json", json);
			return RedirectToAction("Index", "Home", new { app=(""+approval),  grp=("" + groups), srch=(searcher+""),  num=(""+numpage) });
		}
	}
	}


