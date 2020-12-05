using System.Threading.Tasks;
using NUnit.Framework;

namespace WeatherAPI.Test.Integration
{
    [TestFixture]
    public class GetWeatherHappyPath : TestBase
    {
        [Test]
        public async Task WeatherControllerShouldReturn200IfSuccessful()
        {
            Response = await Client.GetAsync("/weather/Chicago");
            Response.EnsureSuccessStatusCode();
            
            Assert.That((int)Response.StatusCode, Is.EqualTo(200));
        }
    }
}