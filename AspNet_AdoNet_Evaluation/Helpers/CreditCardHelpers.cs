using AspNet_AdoNet_Evaluation.Models;
using System.Text.RegularExpressions;

namespace AspNet_AdoNet_Evaluation.Helpers
{
    public static class CreditCardHelpers
    {
        private static Regex mastercardRegex = new Regex("^(51|52|53|54|55)[0-9]{14}$");
        private static Regex visaRegex = new Regex("^(4)([0-9]{12}|[0-9]{15})$");
        private static Regex amexRegex = new Regex("^(34|37)[0-9]{12}$");

        public static bool Isvalid(string cardNumber)
        {
            return mastercardRegex.IsMatch(cardNumber) || visaRegex.IsMatch(cardNumber) || amexRegex.IsMatch(cardNumber);
        }

        public static CardType GetCardType(string cardNumber)
        {
            if (mastercardRegex.IsMatch(cardNumber))
            {
                return CardType.MasterCard;
            }

            if (visaRegex.IsMatch(cardNumber))
            {
                return CardType.Visa;
            }

            if (amexRegex.IsMatch(cardNumber))
            {
                return CardType.AmericanExpress;
            }

            return CardType.Undefined;
        }
    }
}
