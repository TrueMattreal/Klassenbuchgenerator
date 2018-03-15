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
            return string.Format("https://{0}/WebUntis/jsonrpc.do?school={1}", Server, School);
        }
    }
}
