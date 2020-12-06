using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather_API.Models
{
    public class Weather
    {
        [JsonProperty("weather")]
        public JArray Description;
        
        [JsonProperty("main")]
        public JObject Temp;
        
        [JsonProperty("sys")]
        public JObject System;
    }
}