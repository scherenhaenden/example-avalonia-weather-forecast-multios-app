using Newtonsoft.Json;

namespace Weather.Data.Net.Providers.WeatherApi;

public class TemperaturesResponseModel
{
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public LocationModel LocationModel { get; set; }

    [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
    public Current Current { get; set; }
}