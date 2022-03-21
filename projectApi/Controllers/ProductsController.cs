using ApiFunction.Product;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace projectApi.Controllers
{
  
    public class ProductsController : Controller
    {


        private readonly ProductApi productApi;
       // private readonly MessageExtension messageExtension;

        public ProductsController(ProductApi _productApi)
        {
            this.productApi = _productApi;
        }

        [HttpGet]
        //[TypeFilter(typeof(LoginRequiredAttribute))]
        public IActionResult ProductData(int CountryId)
        {
            productApi.GetAllCountries();
            return Json(new { data = ""});
        }

    }
}
