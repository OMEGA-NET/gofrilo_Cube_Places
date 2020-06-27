using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace JobsWeb.Utils
{
    public class Global
    {
        readonly string _apiUrl = ConfigurationManager.AppSettings["JobsWebApiUrl"];

        public HttpResponseMessage rspClientGET(string webService)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer");
            HttpResponseMessage response = client.GetAsync(_apiUrl + webService).Result;

            return response;
        }
    }
}