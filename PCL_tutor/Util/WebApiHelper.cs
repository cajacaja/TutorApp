using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PCL_tutor.Util
{
    public class WebApiHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }
        private string URI = "http://192.168.0.103/api/";
        public WebApiHelper(string route)
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

        public HttpResponseMessage PostResponse(object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {

            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }

        public HttpResponseMessage DeleteResponse(string parameter = "")
        {
            return client.DeleteAsync(route + "/" + parameter).Result;
        }
    }
}
