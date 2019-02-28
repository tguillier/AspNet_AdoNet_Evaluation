using AspNet_AdoNet_Evaluation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_AdoNet_Evaluation.Attributes
{
    public class PasswordRulesAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string password)
            {
                return PasswordHelpers.IsValid(password);
            }
            return base.IsValid(value);
        }
    }
}
