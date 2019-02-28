using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_AdoNet_Evaluation.Models
{
    public enum Currency
    {
        [Display(Name = "€")]
        EUR,
        [Display(Name = "$")]
        USD,
        [Display(Name = "£")]
        GBP
    }
}
