using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialCalculator.Models
{
    public class VcResultsViewModel
    {
        public long StartingShares { get; set; }
        public double YearsToExit { get; set; }
        public double PeRatio { get; set; }
        public double EarningsAtExit { get; set; }

        public IEnumerable<double> Years { get; set; }
        public IEnumerable<double> InvestedFunds { get; set; }
        public IEnumerable<double> RequiredRois { get; set; }
        public IEnumerable<long> NumberOfNewShares { get; set; }
        public IEnumerable<long> TotalShares { get; set; }
        public IEnumerable<double> SharePrice { get; set; }
        public IEnumerable<double> EquityFractions { get; set; }

        public double ExitSharePrice { get; set; }
        public double TotalEquityValue { get; set; }
        public double FractionalEquityValue { get; set; }

    }
}