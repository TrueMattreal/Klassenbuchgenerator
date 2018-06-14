using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Requests
{
    abstract class Params
    {
        public Params(string method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));
            Method = method;
        }

        public string Method { get; }
    }
}
