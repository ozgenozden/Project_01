using ApiFunction.Product;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace projectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {


        private readonly ProductApi productApi;
       // private readonly MessageExtension messageExtension;

        public ProductsController(ProductApi _productApi)
        {
            this.productApi = _productApi;
        }

        [HttpGet("getstrr")]
        //[TypeFilter(typeof(LoginRequiredAttribute))]
        public IActionResult ProductData(int CountryId)
        {
            var res1 = productApi.GetAllCountries();

            //var res=new ProductApi().GetAllCountries();
            return Json(new { data = res1});
        }

    }
}
