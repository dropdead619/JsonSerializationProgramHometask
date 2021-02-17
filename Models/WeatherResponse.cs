namespace Models
{
    public class WeatherResponse
    {
        public Request Request { get; set; }
        public Location Location { get; set; }
        public Current Current { get; set; }
    }
}
