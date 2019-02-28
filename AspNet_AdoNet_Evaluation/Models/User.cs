using AspNet_AdoNet_Evaluation.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_AdoNet_Evaluation.Models
{
    public class User
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [PasswordRules(ErrorMessage = "Password must be at least 8 characters long and match these rules : One or more of each character type (digit, letter, capital letter and special).")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name = "Password confirmation")]
        public string PasswordConfirm { get; set; }

        [Required]
        [CreditCardRules(ErrorMessage = "This card format is not recognized by our system (please type in a MasterCard, Visa or American Express number).")]
        [DataType(DataType.CreditCard)]
        [Display(Name = "Payment card number")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"^(0{1}[1-9]{1}|1{1}[0-2]{1})\/\d{2}$", ErrorMessage = "Expiration date must match the following format : MM/AA.")]
        [Display(Name = "Payment card expiration date")]
        public string ExpirationDate { get; set; }

        public CardType CardType { get; set; }
    }
}
