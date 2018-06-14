using Klassenbuchgenerator.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Responses
{
    abstract class AuthenticationResult
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
        [JsonProperty("personType")]
        public PersonType PersonType { get; set; }
        [JsonProperty("personId")]
        public int PersonId { get; set; }
    }
}
