using Newtonsoft.Json;

namespace Weather.Data.Net.Providers.WeatherApi;

public class Condition
{
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }

    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    public string Icon { get; set; }

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public long? Code { get; set; }
}