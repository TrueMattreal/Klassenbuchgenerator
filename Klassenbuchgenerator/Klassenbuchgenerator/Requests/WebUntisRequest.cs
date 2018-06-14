using Klassenbuchgenerator.Models;
using Klassenbuchgenerator.Responses;
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
        public string SessionId { get; set; }

        public WebUntisResponse<TResponse> Send<TResponse>(WebUntisServiceUrl serviceUrl)
        {
            if (serviceUrl == null)
            {
                throw new ArgumentNullException(nameof(serviceUrl));
            }
            var client = new RestClient(serviceUrl.ToString());
            var request = new RestRequest(RestSharp.Method.POST);
            request.AddHeader("user-agent", "foo");
            request.AddHeader("content-type", "application/json");
            var jsonSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyyMMdd",
            };
            var x = JsonConvert.SerializeObject(this, jsonSettings);
            request.AddParameter("application/json", x, ParameterType.RequestBody);
            if (!string.IsNullOrEmpty(SessionId))
                request.AddParameter("JSESSIONID", SessionId, ParameterType.Cookie);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<WebUntisResponse<TResponse>>(response.Content, jsonSettings);
        }
    }
}
