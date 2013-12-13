using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FinancialCalculator.SpecialReturns;

namespace FinancialCalculator.Functions
{
    public static class VentureCapital
    {
        private static void SortLists(IEnumerable<double> roundYears,
            IEnumerable<double> roundFunds, IEnumerable<double> roundRois,
            out List<double> years, out List<double> funds, out List<double> rois)
        {
            years = new List<double>();
            funds = new List<double>();
            rois = new List<double>();

            // http://stackoverflow.com/a/1760202/1440310
            var sorted = roundYears.ToList().Select((x, i) => new KeyValuePair<double, int>(x, i))
                .OrderBy(x => x.Key)
                .ToList();

            years = sorted.Select(x => x.Key).ToList();
            int[] indexes = sorted.Select(x => x.Value).ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                funds.Add(roundFunds.ElementAt(indexes[i]));
                rois.Add(roundRois.ElementAt(indexes[i]));
            }
        }

        public static VcResults VentureCapitalCalc(IEnumerable<double> roundYears,
            IEnumerable<double> roundFunds, IEnumerable<double> roundRois,
            long startingShares, double yearsToExit, double peRatio,
            double earningsAtExit)
        {
            List<double> years;
            List<double> funds;
            List<double> rois;

            VentureCapital.SortLists(roundYears, roundFunds, roundRois, out years,
                out funds, out rois);
            // Create results with inputs
            VcResults results = new VcResults()
            {
                StartingShares = startingShares,
                YearsToExit = yearsToExit,
                PeRatio = peRatio,
                EarningsAtExit = earningsAtExit,

                Years = years.ToArray(),
                InvestedFunds = funds.ToArray(),
                RequiredRois = rois.ToArray()
            };

            long numRounds = roundYears.Count();

            results.TotalEquityValue = earningsAtExit * peRatio;
            double[] exitValues = new double[numRounds];
            results.EquityFractions = new double[numRounds];
            results.FractionalEquityValue = 0.0;
            for (int i = 0; i < numRounds; i++)
            {
                exitValues[i] = funds.ElementAt(i) *
                    Math.Pow((1 + rois.ElementAt(i)), yearsToExit - years.ElementAt(i));
                results.EquityFractions[i] = exitValues[i] / results.TotalEquityValue;
                results.FractionalEquityValue += results.EquityFractions[i];
            }

            double[] retentionRatios = new double[numRounds];

            for (int i = 0; i < numRounds; i++)
            {
                retentionRatios[i] = 1.0;
                for (int j = 0; j < numRounds; j++)
                {
                    if (i < j)
                    {
                        retentionRatios[i] -= results.EquityFractions[j];
                    }
                }
            }

            double[] initialOwnership = new double[numRounds];
            for (int i = 0; i < numRounds; i++)
            {
                initialOwnership[i] = results.EquityFractions[i] / retentionRatios[i];
            }

            results.NumberOfNewShares = new long[numRounds];
            results.TotalShares = new long[numRounds];
            results.SharePrice = new double[numRounds];

            for (int i = 0; i < numRounds; i++)
            {
                long numShares = results.StartingShares;
                if (i > 0)
                    numShares = results.TotalShares[i - 1];

                results.NumberOfNewShares[i] =
                    (long) Math.Round((initialOwnership[i] * numShares) / (1 - initialOwnership[i]));
                results.TotalShares[i] = numShares + results.NumberOfNewShares[i];
                results.SharePrice[i] = results.InvestedFunds[i] / results.NumberOfNewShares[i];
            }

            results.ExitSharePrice = results.TotalEquityValue / results.TotalShares[numRounds - 1];

            return results;
        }
    }
}
