using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FinancialCalculator.Functions.Utilities;

namespace FinancialCalculator.Functions
{
    public static class Bond
    {
        public static double FindYieldMm(double y, IEnumerable<Object> otherParams)
        {
            double F = (double) otherParams.ElementAt(0);
            double P = (double) otherParams.ElementAt(1);
            double C = (double) otherParams.ElementAt(2);
            long M = (long) otherParams.ElementAt(3);
            long littleM = (long) otherParams.ElementAt(4);
            return BondWithCandyandMm(F, C, y, M, littleM) - P;
        }

        public static double FindYieldN(double y, IEnumerable<Object> otherParams)
        {
            double F = (double) otherParams.ElementAt(0);
            double P = (double) otherParams.ElementAt(1);
            double C = (double) otherParams.ElementAt(2);
            long N = (long) otherParams.ElementAt(3);
            return BondWithCandyandN(F, C, y, N) - P;
        }

        public static double BondWithPandCandMm(double F, double P, double C, long M, long littleM)
        {
            IEnumerable<Object> otherParams = new object[]
                {
                    F, P, C, M, littleM
                };
            var func = new CommonMethods.MyYieldFunction(FindYieldMm);
            return CommonMethods.UseBisectionMethod(func, 1E-10, 100.0, otherParams);
        }

        public static double BondWithPandCandN(double F, double P, double C, long N)
        {
            IEnumerable<Object> otherParams = new object[]
                {
                    F, P, C, N
                };
            var func = new CommonMethods.MyYieldFunction(FindYieldN);
            return CommonMethods.UseBisectionMethod(func, 1E-10, 100.0, otherParams);
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
