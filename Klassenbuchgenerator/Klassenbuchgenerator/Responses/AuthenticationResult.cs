using Klassenbuchgenerator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Responses
{
    abstract class AuthenticationResult
    {
        public string SessionId { get; set; }
        public PersonType PersonType { get; set; }
        public int PersonId { get; set; }
    }
}
