using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Method = RestSharp.Method;

namespace ApiFunction.Product

{
 
    public class ProductApi
    {

        private readonly RestClient Client;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ProductApi()
        {
            Client = new RestClient();
            //httpContextAccessor = _httpContextAccessor;
        }

        public async Task<List<ProductViewModel>> GetAllCountries()
        {
            var request = new RestRequest();
            request.Resource = "http://northwind.now.sh/api/categories";
            //request.AddHeader("Authorization", httpContextAccessor.HttpContext.Session.Get<string>("Token"));
            var response = await Client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<ProductViewModel>>(response.Content);

        }
    }
}
