using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinancialCalculator.Functions;
using FinancialCalculator.Models;

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
            double y = Annuity.AnnuityWithPandCandMm(P, C, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with P and C for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"C", C},
                    {"M", M},
                    {"m", littleM},
                },
                ResultKey = "y",
                ResultValue = y
            };
            return View("../Results/Index", model); 
        }

        [HttpGet]
        public ActionResult AnnuityWithPandCandN(double P, double C, long N)
        {
            double y = Annuity.AnnuityWithPandCandN(P, C, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with P and C for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"C", C},
                    {"N", N},
                },
                ResultKey = "y",
                ResultValue = y
            };
            return View("../Results/Index", model);
        }

        [HttpGet]
        public ActionResult AnnuityWithPandyandMm(double P, double y, long M, long littleM)
        {
            double C = Annuity.AnnuityWithPandyandMm(P, y, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with P and y for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"y", y},
                    {"M", M},
                    {"m", littleM},
                },
                ResultKey = "C",
                ResultValue = C
            };
            return View("../Results/Index", model);
        }

        [HttpGet]
        public ActionResult AnnuityWithPandyandN(double P, double y, long N)
        {
            double C = Annuity.AnnuityWithPandyandN(P, y, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with P and y for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"y", y},
                    {"N", N},
                },
                ResultKey = "C",
                ResultValue = C
            };
            return View("../Results/Index", model);
        }

        [HttpGet]
        public ActionResult AnnuityWithCandyandMm(double C, double y, long M, long littleM)
        {
            double P = Annuity.AnnuityWithCandyandMm(C, y, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with C and y for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"C", C},
                    {"y", y},
                    {"M", M},
                    {"m", littleM},
                },
                ResultKey = "P",
                ResultValue = P
            };
            return View("../Results/Index", model);
        }

        [HttpGet]
        public ActionResult AnnuityWithCandyandN(double C, double y, long N)
        {
            double P = Annuity.AnnuityWithCandyandN(C, y, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Annuity with C and y for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"C", C},
                    {"y", y},
                    {"N", N},
                },
                ResultKey = "P",
                ResultValue = P
            };
            return View("../Results/Index", model);
        }

    }
}
