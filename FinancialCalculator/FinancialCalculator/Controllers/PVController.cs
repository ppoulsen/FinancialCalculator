using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinancialCalculator.Controllers
{
    public class PVController : Controller
    {
        //
        // GET: /PV/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PvWithPAndMm(IEnumerable<double> cashFlows, double P, long M, long littleM, bool repeat, long repeatCount)
        {
            return Redirect("~/PV/"); 
        }

        [HttpGet]
        public ActionResult PvWithPandN(IEnumerable<double> cashFlows, double P, long N, bool repeat, long repeatCount)
        {
            return Redirect("~/PV/"); 
        }

        [HttpGet]
        public ActionResult PvWithyAndMm(IEnumerable<double> cashFlows, double y, long M, long littleM, bool repeat, long repeatCount)
        {
            return Redirect("~/PV/"); 
        }

        [HttpGet]
        public ActionResult PvWithyandN(IEnumerable<double> cashFlows, double y, long N, bool repeat, long repeatCount)
        {
            return Redirect("~/PV/"); 
        }
    }
}
