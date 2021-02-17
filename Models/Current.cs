using System;
using Newtonsoft.Json;

namespace Models
{
    public class Current
    {
        [JsonProperty("observation_time")]
        public DateTime ObservationTime { get; set; }
        public int Temperature { get; set; }
        [JsonProperty("weather_code")]
        public int WeatherCode { get; set; }
        [JsonProperty("weather_icons")]
        public string[] WeatherIconsLink { get; set; }
        [JsonProperty("weather_descriptions")]
        public string[] WeatherDescriptions { get; set; }
        [JsonProperty("wind_speed")]
        public int WindSpeed { get; set; }
        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDirection { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int FeelsLike { get; set; }
        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        [JsonProperty("is_day")]
        public string IsDay { get; set; }
    }
}
