using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Models
{
    class WebUntisServiceUrl
    {
        public string Server { get; set; }
        public string School { get; set; }
        public override string ToString()
        {
            return $"https://{Server}.webuntis.com/WebUntis/jsonrpc.do?school={School}";
        }
    }
}
