using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Mvc
{
    public static class GlobalVeriables
    {
        public static HttpClient WebApiClient = new HttpClient();
        static GlobalVeriables()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44381/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}