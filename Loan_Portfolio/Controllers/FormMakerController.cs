using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loan_Portfolio.Models;
using Newtonsoft.Json;
namespace Loan_Portfolio.Controllers
{
	[Route("FormMaker")]
    public class FormMakerController : Controller
    {
		[Route("Index")]
		public ActionResult Index()
        {
			string[] lenders={ "Barclays", "Metro Bank","RBS","Barkclays Bank Plc","Fifth Third Bank",
							   "HSBC Bank Plc","Nordea", "Santander","Citi","Bank of America Merrill Lynch",
							   "Commerzbank","ING","RBS","Normura","Credit Suisse","Credit Agricole",
							   "Deutche Bank","Societe General","Standard Chartered Bank",
							   "Bank of Tokyo Mitsubishi","Royal bank of Scotland plc","Lloyds Bank Plc",
							   "JP Morgan", "UBS", "Goldman Sachs","ANZ","SEB","Danske","BNP Paribas",
							   "Rabobank"};																						
			ViewBag.lenderList = lenders;
			ViewData["NoDefaultEvent"]=null;
			ViewData["DefaultEvent"]=null;
			return View ();
        }


		[Route("Table")]
		[HttpPost]
		public ActionResult Table(string e) {
			JsonSerializerSettings handle = new JsonSerializerSettings();
			handle.NullValueHandling = NullValueHandling.Ignore;
			DocDetail d;
			d = new DocDetail();
			var objec=JsonConvert.DeserializeObject<object>(e, handle);
			d = (DocDetail)objec;
			List<DocDetail> jj;
			try
			{
				jj = JsonConvert.DeserializeObject<List<DocDetail>>(System.IO.File.ReadAllText(@"\path.json"),handle);
			}
			catch (Exception m)
			{
			jj = new List<DocDetail>();
			}
			jj.Add(d);
			string json = JsonConvert.SerializeObject(jj,handle);
			System.IO.File.WriteAllText(@"\path.json", json);
			return RedirectToAction("Index", "Home");
		}

		[Route("Edit")]
		[HttpPost]
		public ActionResult Edit(string e, int id)
		{
			//string date = d.Date;
			//string docname = d.settings.Docname;

			//List<DocDetail> jj;
			//try
			//{
			//	jj = JsonConvert.DeserializeObject<List<DocDetail>>(System.IO.File.ReadAllText(@"\path.json"));
			//}
			//catch (Exception e)
			//{
			//	jj = new List<DocDetail>();
			//}
			//jj.Add(d);
			//string json = JsonConvert.SerializeObject(jj);
			//System.IO.File.WriteAllText(@"\path.json", json);
			return RedirectToAction("Index", "Home");
		}

		[Route("Viewer")]
		public ActionResult Viewer(int idNum) {
			string[] lenders ={ "Barclays", "Metro Bank","RBS","Barkclays Bank Plc","Fifth Third Bank",
							   "HSBC Bank Plc","Nordea", "Santander","Citi","Bank of America Merrill Lynch",
							   "Commerzbank","ING","RBS","Normura","Credit Suisse","Credit Agricole",
							   "Deutche Bank","Societe General","Standard Chartered Bank",
							   "Bank of Tokyo Mitsubishi","Royal bank of Scotland plc","Lloyds Bank Plc",
							   "JP Morgan", "UBS", "Goldman Sachs","ANZ","SEB","Danske","BNP Paribas",
							   "Rabobank"};
			ViewBag.lenderList = lenders;
			ViewData["NoDefaultEvent"] = null;
			ViewData["DefaultEvent"] = null;
			List<DocDetail> jj;
			try
			{
				jj = JsonConvert.DeserializeObject<List<DocDetail>>(System.IO.File.ReadAllText(@"\path.json"));
			}
			catch (Exception e)
			{
				jj = new List<DocDetail>();
			}
			DocDetail d = jj[idNum];
			ViewData["DocDetail"] = d;
			string s = d.Security.p1;
			ViewData["security1"]=s;
			return View();
		}


		[Route("Editor")]
		public ActionResult Editor(int idNum)
		{
			
			string[] lenders ={ "Barclays", "Metro Bank","RBS","Barkclays Bank Plc","Fifth Third Bank",
							   "HSBC Bank Plc","Nordea", "Santander","Citi","Bank of America Merrill Lynch",
							   "Commerzbank","ING","RBS","Normura","Credit Suisse","Credit Agricole",
							   "Deutche Bank","Societe General","Standard Chartered Bank",
							   "Bank of Tokyo Mitsubishi","Royal bank of Scotland plc","Lloyds Bank Plc",
							   "JP Morgan", "UBS", "Goldman Sachs","ANZ","SEB","Danske","BNP Paribas",
							   "Rabobank"};
			ViewBag.lenderList = lenders;
			ViewData["NoDefaultEvent"] = null;
			ViewData["DefaultEvent"] = null;
			List<DocDetail> jj;
			try
			{
				jj = JsonConvert.DeserializeObject<List<DocDetail>>(System.IO.File.ReadAllText(@"\path.json"));
			}
			catch (Exception e)
			{
				jj = new List<DocDetail>();
			}
			DocDetail d = jj[idNum];
			string json = JsonConvert.SerializeObject(d);
			ViewData["DocDetail"] = json;
			return View();
		}
    }
	 
}
