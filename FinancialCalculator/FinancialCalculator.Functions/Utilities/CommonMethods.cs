using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialCalculator.Functions.Utilities
{
    public static class CommonMethods
    {
        public delegate double MyYieldFunction(double y, IEnumerable<Object> otherParams);

        public static double UseBisectionMethod(MyYieldFunction func, double lower, double upper, IEnumerable<Object> otherParams, double tolerance = 1E-10)
        {
            double newBound = lower;
            double newBoundValue;
            double range = upper - lower;

            double lowerValue = func(lower, otherParams);
            double upperValue = func(upper, otherParams);

            while (range > tolerance)
            {
                newBound = (upper + lower) / 2;
                range = upper - newBound;

                newBoundValue = func(newBound, otherParams);
                if (newBoundValue == 0.0)
                    return newBound;
                if (lowerValue * newBoundValue > 0.0)
                {
                    lower = newBound;
                    lowerValue = newBoundValue;
                }
                else
                {
                    upper = newBound;
                    upperValue = newBoundValue;
                }
            }
            return newBound;
        }
    }
}
