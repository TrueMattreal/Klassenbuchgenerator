using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Requests
{
    class AuthenticationParams
    {
        [JsonProperty("user")]
        public string User { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
    }
}
