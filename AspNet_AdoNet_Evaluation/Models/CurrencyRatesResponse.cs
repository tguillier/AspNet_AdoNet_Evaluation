using System.Collections.Generic;

namespace AspNet_AdoNet_Evaluation.Models
{
    public class CurrencyRatesResponse
    {
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}