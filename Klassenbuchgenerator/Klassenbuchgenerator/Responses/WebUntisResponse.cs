using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Responses
{
    abstract class WebUntisResponse<T>
    {
        public string JsonRpc { get; set; }
        public string Id { get; set; }
        public T Result { get; set; }
    }
}
