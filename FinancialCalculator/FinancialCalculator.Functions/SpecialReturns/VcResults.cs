using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialCalculator.SpecialReturns
{
    public class VcResults
    {
        public long StartingShares { get; set; }
        public double YearsToExit { get; set; }
        public double PeRatio { get; set; }
        public double EarningsAtExit { get; set; }

        public double[] Years { get; set; }
        public double[] InvestedFunds { get; set; }
        public double[] RequiredRois { get; set; }
        public long[] NumberOfNewShares { get; set; }
        public long[] TotalShares { get; set; }
        public double[] SharePrice { get; set; }
        public double[] EquityFractions { get; set; }

        public double ExitSharePrice { get; set; }
        public double TotalEquityValue { get; set; }
        public double FractionalEquityValue { get; set; }

    }
}