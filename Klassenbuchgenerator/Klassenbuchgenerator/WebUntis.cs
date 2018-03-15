using Klassenbuchgenerator.Models;
using Klassenbuchgenerator.Requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator
{
    class WebUntis
    {
        private readonly WebUntisServiceUrl serviceUrl;

        public WebUntis(WebUntisServiceUrl serviceUrl)
        {
            this.serviceUrl = serviceUrl;
        }

        public void Authenticate(AuthenticationParams authenticationParams)
        {
            if (authenticationParams == null)
            {
                throw new ArgumentNullException(nameof(authenticationParams));
            }
            new Requests.WebUntisRequest<Requests.AuthenticationParams>()
            {
                Id = "rolfcopter",
                JsonRpc = "2.0",
                Method = "Authenticate",
                Params = authenticationParams,
            }.Send(serviceUrl);
        }
    }
}
