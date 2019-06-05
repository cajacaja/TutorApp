using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_UI.Util
{
   public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        private string URI =  "http://192.168.0.103/api/";//"http://localhost:61494/api/";
        public WebAPIHelper(string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(URI);
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

        public HttpResponseMessage PostResponse(Object newObject)
        {
            return client.PostAsJsonAsync(route, newObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
                        
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }

        public HttpResponseMessage DeleteResponse(string parameter = "")
        {
            return client.DeleteAsync(route + "/" + parameter).Result;
        }
    }
}
