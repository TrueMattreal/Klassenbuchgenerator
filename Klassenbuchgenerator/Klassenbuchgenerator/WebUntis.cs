using Klassenbuchgenerator.Models;
using Klassenbuchgenerator.Requests;
using Klassenbuchgenerator.Responses;
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
        private readonly WebUntisRequestFactory factory;

        public WebUntis(WebUntisServiceUrl serviceUrl, WebUntisRequestFactory factory)
        {
            this.serviceUrl = serviceUrl;
            this.factory = factory;
        }

        public void Authenticate(AuthenticationParams authenticationParams)
        {
            if (authenticationParams == null)
            {
                throw new ArgumentNullException(nameof(authenticationParams));
            }
            var response = factory
                .GetRequest(authenticationParams)
                .Send<AuthenticationResult>(serviceUrl);
            factory.SessionId = response.Result.SessionId;
        }
        public void Logout(LogoutParams logoutParams)
        {
            var response = factory
                .GetRequest(logoutParams)
                .Send<LogoutParams>(serviceUrl);
        }
        public void GetTimeTable(GetTimetableParams getTimetableParams)
        {
            var response = factory
                .GetRequest(getTimetableParams)
                .Send<PeriodObject[]>(serviceUrl);
            foreach (var periodObject in response.Result)
            {
                Console.WriteLine(periodObject);
            }
        }
    }
}
