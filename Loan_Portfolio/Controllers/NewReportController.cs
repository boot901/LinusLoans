using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loan_Portfolio.Controllers
{
	[Route("newReport")]
    public class NewReportController : Controller
    {
		[Route("Index")]
        public ActionResult Index()
        {
            return View ();
        }
    }
}
