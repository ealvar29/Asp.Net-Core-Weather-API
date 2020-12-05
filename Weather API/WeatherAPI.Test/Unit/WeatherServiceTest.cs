using NUnit.Framework;
using Weather_API.Models;

namespace WeatherAPI.Test.Unit
{
    [TestFixture]
    public class WeatherServiceTest
    {
        private WeatherService _service;
        
        [SetUp]
        public void Setup()
        {
            _service = new WeatherService();
        }
        
        [Test]
        public void GetWeatherForLocationShouldReturnATypeOfWeather()
        {
            var weather = _service.GetWeatherForLocation("Chicago");
            Assert.That(weather , Is.TypeOf<Weather>());
        }
    }
}