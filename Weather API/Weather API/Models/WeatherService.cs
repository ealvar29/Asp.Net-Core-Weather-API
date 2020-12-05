namespace Weather_API.Models
{
    public class WeatherService : IWeatherService
    {
        public Weather GetWeatherForLocation(string location)
        {
            return new Weather();
        }
    }

    public interface IWeatherService
    {
        public Weather GetWeatherForLocation(string location);
    }

    public class Weather
    {
        
    }
}