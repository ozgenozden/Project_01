using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using projectApi.Pages;
using projectApi.Models;
using ApiFunction.Product;

namespace projectApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductApi productApi;

        public HomeController(ILogger<HomeController> logger, ProductApi _productApi)
        {
            _logger = logger;
            this.productApi = _productApi;
        }

        //[HttpGet]
        ////[TypeFilter(typeof(LoginRequiredAttribute))]
        //public IActionResult ProductData(int CountryId)
        //{
        //    productApi.GetAllCountries();
        //    return Json(new { data = "" });
        //}
        [HttpGet]
        public IActionResult Index()
        {

            var rss=productApi.GetAllCountries();
            return Json(new { data =rss });
           // return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
