using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Requests
{
    class WebUntisRequestFactory
    {
        public string Id { get; set; }
        public string JsonRpc { get; set; }
        public string SessionId { get; set; }

        public WebUntisRequest<T> GetRequest<T>(T parameters) where T : Params
        {
            var request = new WebUntisRequest<T>()
            {
                Id = Id,
                JsonRpc = JsonRpc,
                Params = parameters,
                Method = parameters.Method,
                SessionId = SessionId,
            };
            return request;
        }
    }
}
