using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Weather_API;

namespace WeatherAPI.Test
{
    public abstract class TestBase : Xunit.IClassFixture<WebApplicationFactory<Startup>> 
    {
        [SetUp]
        public void Setup()
        {
            Client = HttpApplicationFactory.CreateClient();
        }

        protected readonly WebApplicationFactory<Startup> HttpApplicationFactory;
        protected HttpClient Client;
        protected HttpResponseMessage Response;

        protected TestBase()
        {
            HttpApplicationFactory = new WebApplicationFactory<Startup>();
        }
    }
}