using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather_API.Models
{
    public class WeatherService : IWeatherService
    {
        public async Task<Weather> GetWeatherForLocation(string location)
        {
            var key = "Change Me";
            var client = new HttpClient();
            var response = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={location}&appid={key}");
            var json = await response.Content.ReadAsStringAsync();
            var weather = JsonConvert.DeserializeObject<Weather>(json);
            
            return weather;
        }
    }
}