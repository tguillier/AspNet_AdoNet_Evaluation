using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AspNet_AdoNet_Evaluation.Models;
using Newtonsoft.Json;

namespace AspNet_AdoNet_Evaluation.Services
{
    public class CurrencyConverterService : ICurrencyConverterService
    {
        private readonly HttpClient httpClient;

        public CurrencyConverterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public CurrencyConverterResult GetConversionResult(CurrencyConverterConfiguration configuration)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync($"https://api.exchangeratesapi.io/latest?base={configuration.CurrencyFrom.ToString()}").Result;

            var contentString = response.Content.ReadAsStringAsync().Result;
            var jsonResponse = JsonConvert.DeserializeObject<CurrencyRatesResponse>(contentString);

            if (jsonResponse.Rates.TryGetValue(configuration.CurrencyTo.ToString(), out decimal rate))
            {
                return new CurrencyConverterResult
                {
                    ChangeRate = rate,
                    ConvertedAmount = configuration.Amount * rate
                };
            }

            return null;
        }
    }
}
