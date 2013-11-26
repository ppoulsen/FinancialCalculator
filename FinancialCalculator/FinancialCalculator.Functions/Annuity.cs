using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialCalculator.Functions
{
    public static class Annuity
    {
        public static double AnnuityWithPandCandMm(double P, double C, long M, long littleM)
        {
            return 0.0;
        }

        public static double AnnuityWithPandCandN(double P, double C, long N)
        {
            return 0.0;
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
