using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbuchgenerator.Models
{
    class PeriodObject
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("startTime")]
        public TimeSpan StartTime { get; set; }
        [JsonProperty("endTime")]
        public TimeSpan EndTime { get; set; }
        [JsonProperty("kl")]
        public int[] KlassenIds { get; set; }
        [JsonProperty("te")]
        public int[] TeacherIds { get; set; }
        [JsonProperty("su")]
        public int[] SubjectIds { get; set; }
        [JsonProperty("ro")]
        public int[] RoomIds { get; set; }
        [JsonProperty("lstype")]
        public string LessonType { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("lstext")]
        public string LessonText { get; set; }
        [JsonProperty("statflags")]
        public int? StatFlags { get; set; }
        [JsonProperty("activityType")]
        public int? ActivityType { get; set; }

        public override string ToString()
        {
            return $"{Date}";
        }
    }
}
