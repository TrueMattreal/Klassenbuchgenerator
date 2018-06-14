using Klassenbuchgenerator.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Requests
{
    class GetTimetableParams : Params
    {
        public GetTimetableParams() : base("getTimetable") { }

        [JsonProperty("type")]
        public PersonType Type { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }
    }
}
