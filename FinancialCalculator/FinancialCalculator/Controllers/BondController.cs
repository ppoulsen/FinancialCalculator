using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinancialCalculator.Controllers
{
    public class BondController : Controller
    {
        //
        // GET: /Bond/

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult BondWithPandCandMm(double F, double P, double C, long M, long m)
        {
            return Redirect("~/Bond/");
        }

        [HttpGet]
        public ActionResult BondWithPandCandN(double F, double P, double C, long N)
        {
            return Redirect("~/Bond/");
        }

        [HttpGet]
        public ActionResult BondWithPandyandMm(double F, double P, double y, long M, long m)
        {
            return Redirect("~/Bond/");
        }

        [HttpGet]
        public ActionResult BondWithPandyandN(double F, double P, double y, long N)
        {
            return Redirect("~/Bond/");
        }

        [HttpGet]
        public ActionResult BondWithCandyandMm(double F, double C, double y, long M, long m)
        {
            return Redirect("~/Bond/");
        }

        [HttpGet]
        public ActionResult BondWithCandyandN(double F, double C, double y, long N)
        {
            return Redirect("~/Bond/");
        }
    }
}
