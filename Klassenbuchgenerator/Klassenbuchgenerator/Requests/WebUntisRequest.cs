using Klassenbuchgenerator.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Requests
{
    class WebUntisRequest<T>
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("params")]
        public T Params { get; set; }
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        public void Send(WebUntisServiceUrl serviceUrl)
        {
            if (serviceUrl == null)
            {
                throw new ArgumentNullException(nameof(serviceUrl));
            }
            var client = new RestClient(serviceUrl.ToString());
            var request = new RestRequest(RestSharp.Method.POST);
            request.AddHeader("user-agent", "foo");
            request.AddHeader("content-type", "application/json");
            var x = JsonConvert.SerializeObject(this);
            request.AddParameter("application/json", JsonConvert.SerializeObject(this));
            IRestResponse response = client.Execute(request);
            
        }
    }
}
