using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AspNet_AdoNet_Evaluation.Helpers
{
    public static class PasswordHelpers
    {
        public static bool IsValid(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            var oneOrMoreLetterRegex = new Regex(@"[a-z]+");
            var oneOrMoreCapitalLetterRegex = new Regex(@"[A-Z]+");
            var oneOrMoreDigitRegex = new Regex(@"\d+");
            var oneOrMoreSpecialCharRegex = new Regex(@"[@#&%!=?+\-*\/\.]");

            if (!oneOrMoreLetterRegex.IsMatch(password) ||
                !oneOrMoreCapitalLetterRegex.IsMatch(password) ||
                !oneOrMoreDigitRegex.IsMatch(password) ||
                !oneOrMoreSpecialCharRegex.IsMatch(password))
            {
                return false;
            }

            return true;
        }
    }
}
