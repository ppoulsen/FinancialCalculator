using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinancialCalculator.Functions;
using FinancialCalculator.Models;

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
        public ActionResult BondWithPandCandMm(double F, double P, double C, long M, long littleM)
        {
            double y = Bond.BondWithPandCandMm(P, C, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, P, and C for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
        public ActionResult BondWithPandCandN(double F, double P, double C, long N)
        {
            double y = Bond.BondWithPandCandN(P, C, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, P, and C for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
        public ActionResult BondWithPandyandMm(double F, double P, double y, long M, long littleM)
        {
            double C = Bond.BondWithPandyandMm(P, y, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, P, and y for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
        public ActionResult BondWithPandyandN(double F, double P, double y, long N)
        {
            double C = Bond.BondWithPandyandN(P, y, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, P, and y for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
        public ActionResult BondWithCandyandMm(double F, double C, double y, long M, long littleM)
        {
            double P = Bond.BondWithCandyandMm(C, y, M, littleM);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, C, and y for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
        public ActionResult BondWithCandyandN(double F, double C, double y, long N)
        {
            double P = Bond.BondWithCandyandN(C, y, N);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for Bond with F, C, and y for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"F", F},
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
