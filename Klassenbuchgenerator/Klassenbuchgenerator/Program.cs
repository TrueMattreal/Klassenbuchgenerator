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
            try
            {
                webUntis.Authenticate(new Requests.AuthenticationParams()
                {
                    Client = "foo",
                    Password = credentials.Password,
                    User = credentials.Username,
                });
                webUntis.GetTimeTable(new Requests.GetTimetableParams()
                {
                    Id = 140,
                    Type = Types.PersonType.Teacher,
                    EndDate = new DateTime(2018, 1, 1),
                    StartDate = new DateTime(2018, 12, 31),
                });
            }
            finally
            {
                webUntis.Logout(new Requests.LogoutParams());
            }
        }
    }
}
