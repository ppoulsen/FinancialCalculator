using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialCalculator.Functions
{
    public static class PV
    {
        public static double PvWithPAndMm(IEnumerable<double> cashFlows, double P, long M, long littleM, bool repeat, long repeatCount)
        {
            return 0.0;
        }

        public static double PvWithPandN(IEnumerable<double> cashFlows, double P, long N, bool repeat, long repeatCount)
        {
            return 0.0;
        }

        public static double PvWithyAndMm(IEnumerable<double> cashFlows, double y, long M, long littleM, bool repeat, long repeatCount)
        {
            double sum = 0.0;
            int count = cashFlows.Count();
            int total = count;
            if (repeat)
                total += unchecked((int)repeatCount);
            for (int i = 0; i < total; i++)
            {
                double cf;
                if (i < count)
                    cf = cashFlows.ElementAt(i);
                else
                    cf = cashFlows.ElementAt(count - 1);
                double discount = Math.Pow(1 + y / littleM, i);
                sum += (cf / discount);
            }
            return sum;
        }

        public static double PvWithyandN(IEnumerable<double> cashFlows, double y, long N, bool repeat, long repeatCount)
        {
            double sum = 0.0;
            int count = cashFlows.Count();
            int total = count;
            if (repeat)
                total += unchecked((int)repeatCount);
            for (int i = 0; i < total; i++)
            {
                double cf;
                if (i < count)
                    cf = cashFlows.ElementAt(i);
                else
                    cf = cashFlows.ElementAt(count - 1);
                double discount = Math.Pow(1 + y, i);
                sum += (cf / discount);
            }
            return sum;
        }
    }
}
