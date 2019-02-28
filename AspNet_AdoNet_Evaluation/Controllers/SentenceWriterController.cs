using AspNet_AdoNet_Evaluation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_AdoNet_Evaluation.Controllers
{
    public class SentenceWriterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SentenceWriterConfiguration configuration)
        {
            if (ModelState.IsValid)
            {
                // Equivalent de if(!configuration.NumberOfRepetitions.HasValue) configuration.NumberOfRepetitions = 10;
                configuration.NumberOfRepetitions = configuration.NumberOfRepetitions ?? 10;
                return View("Result", configuration);
            }
            return View(configuration);
        }
    }
}