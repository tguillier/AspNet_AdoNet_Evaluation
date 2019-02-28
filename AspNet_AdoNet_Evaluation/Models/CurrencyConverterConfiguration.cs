using System.ComponentModel.DataAnnotations;

namespace AspNet_AdoNet_Evaluation.Models
{
    public class CurrencyConverterConfiguration
    {
        [Required(ErrorMessage = "An amount must be defined.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please define the amount currency.")]
        [Display(Name = "From currency")]
        public Currency CurrencyFrom { get; set; }

        [Required(ErrorMessage = "Please define the target currency.")]
        [Display(Name = "To currency")]
        public Currency CurrencyTo { get; set; }
    }
}