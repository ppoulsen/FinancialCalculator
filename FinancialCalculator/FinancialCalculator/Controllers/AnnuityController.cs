using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinancialCalculator.Controllers
{
    public class AnnuityController : Controller
    {
        //
        // GET: /Annuity/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AnnuityWithPandCandMm(double P, double C, long M, long littleM)
        {
            return Redirect("~/Annuity/");
        }

        [HttpGet]
        public ActionResult AnnuityWithPandCandN(double P, double C, long N)
        {
            return Redirect("~/Annuity/");
        }

        [HttpGet]
        public ActionResult AnnuityWithPandyandMm(double P, double y, long M, long littleM)
        {
            return Redirect("~/Annuity/");
        }

        [HttpGet]
        public ActionResult AnnuityWithPandyandN(double P, double y, long N)
        {
            return Redirect("~/Annuity/");
        }

        [HttpGet]
        public ActionResult AnnuityWithCandyandMm(double C, double y, long M, long littleM)
        {
            return Redirect("~/Annuity/");
        }

        [HttpGet]
        public ActionResult AnnuityWithCandyandN(double C, double y, long N)
        {
            return Redirect("~/Annuity/");
        }

    }
}
