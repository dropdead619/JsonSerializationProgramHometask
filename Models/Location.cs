using System;
using Newtonsoft.Json;

namespace Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longitude { get; set; }
        [JsonProperty("timezone_id")]
        public string TimezoneId { get; set; }
        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }
        [JsonProperty("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }
        [JsonProperty("utc_offset")]
        public double UtcOffset { get; set; }
    }
}
