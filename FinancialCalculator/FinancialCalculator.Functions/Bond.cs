using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialCalculator.Functions
{
    public static class Bond
    {
        public static double BondWithPandCandMm(double F, double P, double C, long M, long littleM)
        {
            return 0.0;
        }

        public static double BondWithPandCandN(double F, double P, double C, long N)
        {
            return 0.0;
        }

        public static double BondWithPandyandMm(double F, double P, double y, long M, long littleM)
        {
            double left = P;
            double bottom = ((1 / (y / littleM)) - (1 / ((y / littleM) * (Math.Pow((1 + (y / littleM)), M)))));
            double right = F / (Math.Pow((1 + (y / littleM)), M));
            return (left - right) / bottom;
        }

        public static double BondWithPandyandN(double F, double P, double y, long N)
        {
            double left = P;
            double bottom = ((1 / y) - (1 / (y * (Math.Pow((1 + y), N)))));
            double right = F / (Math.Pow((1 + y), N));
            return (left - right) / bottom;
        }

        public static double BondWithCandyandMm(double F, double C, double y, long M, long littleM)
        {
            double left = C;
            double middle = ((1 / (y / littleM)) - (1 / ((y / littleM) * (Math.Pow((1 + (y / littleM)), M)))));
            double right = F / (Math.Pow((1 + (y / littleM)), M));
            return left * middle + right;
        }

        public static double BondWithCandyandN(double F, double C, double y, long N)
        {
            double left = C;
            double middle = ((1 / y) - (1 / (y * (Math.Pow((1 + y), N)))));
            double right = F / (Math.Pow((1 + y), N));
            return left * middle + right;
        }

    }
}
