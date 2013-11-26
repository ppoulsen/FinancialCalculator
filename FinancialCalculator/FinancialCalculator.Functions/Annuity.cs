using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FinancialCalculator.Functions.Utilities;

namespace FinancialCalculator.Functions
{
    public static class Annuity
    {
        public static double FindYieldMm(double y, IEnumerable<Object> otherParams)
        {
            double P = (double) otherParams.ElementAt(0);
            double C = (double) otherParams.ElementAt(1);
            long M = (long) otherParams.ElementAt(2);
            long littleM = (long) otherParams.ElementAt(3);
            return AnnuityWithCandyandMm(C, y, M, littleM) - P;
        }

        public static double FindYieldN(double y, IEnumerable<Object> otherParams)
        {
            double P = (double) otherParams.ElementAt(0);
            double C = (double) otherParams.ElementAt(1);
            long N = (long) otherParams.ElementAt(2);
            return AnnuityWithCandyandN(C, y, N) - P;
        }

        public static double AnnuityWithPandCandMm(double P, double C, long M, long littleM)
        {
            IEnumerable<Object> otherParams = new object[]
                {
                    P, C, M, littleM
                };
            var func = new CommonMethods.MyYieldFunction(FindYieldMm);
            return CommonMethods.UseBisectionMethod(func, 1E-10, 100.0, otherParams);
        }

        public static double AnnuityWithPandCandN(double P, double C, long N)
        {
            IEnumerable<Object> otherParams = new object[]
                {
                    P, C, N
                };
            var func = new CommonMethods.MyYieldFunction(FindYieldN);
            return CommonMethods.UseBisectionMethod(func, 1E-10, 100.0, otherParams);
        }

        public static double AnnuityWithPandyandMm(double P, double y, long M, long littleM)
        {
            double numerator = P * (y / littleM) * (Math.Pow((1 + (y / littleM)), M));
            double denominator = Math.Pow((1 + (y / littleM)), M) - 1;
            return (numerator / denominator);
        }

        public static double AnnuityWithPandyandN(double P, double y, long N)
        {
            double numerator = P * y  * (Math.Pow(1 + y, N));
            double denominator = Math.Pow(1 + y, N) - 1;
            return (numerator / denominator);
        }

        public static double AnnuityWithCandyandMm(double C, double y, long M, long littleM)
        {
            double left = C * littleM / y;
            double right = (1 - (Math.Pow((1 + (y / littleM)), -M)));
            return (left * right);
        }

        public static double AnnuityWithCandyandN(double C, double y, long N)
        {
            double left = C / y;
            double right = (1 - (Math.Pow(1 + y, -N)));
            return (left * right);
        }
    }
}
