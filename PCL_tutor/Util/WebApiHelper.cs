using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Util
{
    public class WebApiHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebApiHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;

        }
        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return client.GetAsync(route + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

       

        public HttpResponseMessage DeleteResponse(string parameter = "")
        {
            return client.DeleteAsync(route + "/" + parameter).Result;
        }
    }
}
