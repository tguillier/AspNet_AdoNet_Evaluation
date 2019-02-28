using AspNet_AdoNet_Evaluation.Models;
using AspNet_AdoNet_Evaluation.Services;
using AspNet_AdoNet_Evaluation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace AspNet_AdoNet_Evaluation.Controllers
{
    public class CurrencyConverterController : Controller
    {
        private readonly ICurrencyConverterService service;

        public CurrencyConverterController(ICurrencyConverterService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CurrencyConverterConfiguration configuration)
        {
            if (ModelState.IsValid)
            {
                var viewModel = GetCurrencyConverterViewModel(configuration);
                if (viewModel is null)
                {
                    ModelState.AddModelError("", "An error occured while getting the change rate, please retry.");
                    return View(configuration);
                }

                return View("Result", viewModel);
            }
            return View(configuration);
        }

        private CurrencyConverterViewModel GetCurrencyConverterViewModel(CurrencyConverterConfiguration configuration)
        {
            return new CurrencyConverterViewModel
            {
                Configuration = configuration,
                Result = service.GetConversionResult(configuration)
            };
        }
    }
}