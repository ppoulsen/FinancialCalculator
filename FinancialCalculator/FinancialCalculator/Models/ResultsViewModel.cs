using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialCalculator.Models
{
    public class ResultsViewModel
    {
        public string Title;
        public Dictionary<string, Object> Parameters;
        public string ResultKey;
        public Object ResultValue;
    }
}