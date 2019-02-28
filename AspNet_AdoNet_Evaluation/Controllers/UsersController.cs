using AspNet_AdoNet_Evaluation.Data;
using AspNet_AdoNet_Evaluation.Helpers;
using AspNet_AdoNet_Evaluation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNet_AdoNet_Evaluation.Controllers
{
    public class UsersController : Controller
    {
        private readonly EvaluationContext _context;

        public UsersController(EvaluationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Password.ToLower().Contains(user.Email.ToLower().Split("@").First()))
                {
                    ModelState.AddModelError("Password", "The password must not match your email address.");
                    return View("Index", user);
                }

                user.CardType = CreditCardHelpers.GetCardType(user.CardNumber);

                _context.Add(user);
                _context.SaveChanges();
                return View("Result", user);
            }
            return View("Index", user);
        }
    }
}
