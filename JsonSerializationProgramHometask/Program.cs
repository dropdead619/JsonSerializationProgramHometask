using Newtonsoft.Json;
using Models;
using System.IO;

namespace JsonSerializationProgramHometask
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "weather.json";
            var jsonAsText = " ";
            if (File.Exists(path)) {
                using(var stream = File.OpenText(path))
                {
                    jsonAsText = stream.ReadToEnd();
                }
            }           
            var weatherList = JsonConvert.DeserializeObject<WeatherResponse>(jsonAsText);           
        }
    }
}
