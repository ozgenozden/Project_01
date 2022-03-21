using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFunction
{
    public class ApiFunctionHelper
    {
        public static RestRequest addQuerystringParameters(RestRequest request, object filter)
        {
            if (filter != null)
            {
                foreach (var item in filter.GetType().GetProperties())
                {
                    if (item.GetValue(filter) != null)
                        request.AddParameter(item.Name.ToString(), item.GetValue(filter).ToString(), ParameterType.QueryString);
                }
            }

            request.AddParameter("Take", Vars.Take, ParameterType.QueryString);
            return request;
        }
    }
}
