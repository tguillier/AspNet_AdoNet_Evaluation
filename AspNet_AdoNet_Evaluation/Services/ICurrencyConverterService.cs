using AspNet_AdoNet_Evaluation.Models;

namespace AspNet_AdoNet_Evaluation.Services
{
    public interface ICurrencyConverterService
    {
        CurrencyConverterResult GetConversionResult(CurrencyConverterConfiguration configuration);
    }
}