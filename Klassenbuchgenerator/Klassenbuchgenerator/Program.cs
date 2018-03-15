using Klassenbuchgenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new WebUntisCredentials()
            {
                Password = "PASSWORD",
                Username = "USERNAME",
            };
            var serviceUrl = new WebUntisServiceUrl()
            {
                School = "SCHOOL",
                Server = "SERVER",
            };
            var webUntis = new WebUntis(serviceUrl);
            // TODO make it work
            webUntis.Authenticate(new Requests.AuthenticationParams()
            {
                Client = "foo",
                Password = credentials.Password,
                User = credentials.Username,
            });
        }
    }
}
