using System.Threading.Tasks;

namespace Weather_API.Models
{
    public interface IWeatherService
    {
        public Task<Weather> GetWeatherForLocation(string location);
    }
}