using Microsoft.AspNetCore.Http;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Method = RestSharp.Method;

namespace ApiFunction.Product
{
    public class ProductApi
    {

        private readonly RestClient Client;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ProductApi(IHttpContextAccessor _httpContextAccessor)
        {
            Client = new RestClient(Vars.ApiAddress);
            httpContextAccessor = _httpContextAccessor;
        }

        public void GetAllCountries()
        {
            var request = new RestRequest();
            request.Resource = "northwind.now.sh/api/categories";
            //request.AddHeader("Authorization", httpContextAccessor.HttpContext.Session.Get<string>("Token"));
            var response = Client.ExecuteAsync(request);
            //return response;
        }
    }
}
