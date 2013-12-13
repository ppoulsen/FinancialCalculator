using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinancialCalculator.Functions;
using FinancialCalculator.Models;
using FinancialCalculator.SpecialReturns;

namespace FinancialCalculator.Controllers
{
    public class VentureCapitalController : Controller
    {
        //
        // GET: /VentureCapital/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calculate(IEnumerable<double> roundYears,
            IEnumerable<double> roundFunds, IEnumerable<double> roundRois,
            long startingShares, double yearsToExit, double peRatio,
            double earningsAtExit)
        {
            VcResults results = VentureCapital.VentureCapitalCalc(
                roundYears, roundFunds, roundRois, startingShares, yearsToExit,
                peRatio, earningsAtExit);

            VcResultsViewModel model = new VcResultsViewModel()
            {
                StartingShares = results.StartingShares,
                YearsToExit = results.YearsToExit,
                PeRatio = results.PeRatio,
                EarningsAtExit = results.EarningsAtExit,
                Years = results.Years,
                InvestedFunds = results.InvestedFunds,
                RequiredRois = results.RequiredRois,
                NumberOfNewShares = results.NumberOfNewShares,
                TotalShares = results.TotalShares,
                SharePrice = results.SharePrice,
                EquityFractions = results.EquityFractions,
                ExitSharePrice = results.ExitSharePrice,
                TotalEquityValue = results.TotalEquityValue,
                FractionalEquityValue = results.FractionalEquityValue
            };
            return View(model);
        }
    }
}
