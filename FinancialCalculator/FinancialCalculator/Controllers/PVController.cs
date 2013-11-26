using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinancialCalculator.Functions;
using FinancialCalculator.Models;

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
            double y = PV.PvWithPAndMm(cashFlows, P, M, littleM, repeat, repeatCount);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for PV with Cash Flows and P for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"M", M},
                    {"m", littleM},
                },
                ResultKey = "y",
                ResultValue = y
            };
            return View("../Results/Index", model); 
        }

        [HttpGet]
        public ActionResult PvWithPandN(IEnumerable<double> cashFlows, double P, long N, bool repeat, long repeatCount)
        {
            double y = PV.PvWithPandN(cashFlows, P, N, repeat, repeatCount);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for PV with Cash Flows and P for N periods",
                Parameters = new Dictionary<string,object>()
                {
                    {"P", P},
                    {"N", N},
                },
                ResultKey = "y",
                ResultValue = y
            };
            return View("../Results/Index", model); 
        }

        [HttpGet]
        public ActionResult PvWithyAndMm(IEnumerable<double> cashFlows, double y, long M, long littleM, bool repeat, long repeatCount)
        {
            double P = PV.PvWithyAndMm(cashFlows, y, M, littleM, repeat, repeatCount);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for PV with Cash Flows and y for periods M/m",
                Parameters = new Dictionary<string,object>()
                {
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
        public ActionResult PvWithyandN(IEnumerable<double> cashFlows, double y, long N, bool repeat, long repeatCount)
        {
            double P = PV.PvWithyandN(cashFlows, y, N, repeat, repeatCount);
            ResultsViewModel model = new ResultsViewModel()
            {
                Title = "Results for PV with Cash Flows and y for N periods",
                Parameters = new Dictionary<string,object>()
                {
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
