using AspNet_AdoNet_Evaluation.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AspNet_AdoNet_Evaluation.Attributes
{
    public class CreditCardRulesAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string cardNumber)
            {
                return CreditCardHelpers.Isvalid(cardNumber);
            }

            return false;
        }
    }
}
