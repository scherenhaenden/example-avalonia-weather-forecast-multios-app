using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weather.Data.Net.ProofOfConcepts;

public partial class Temperatures
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("local_names", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> LocalNames { get; set; }

    [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; }

    [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lon { get; set; }

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    public string Country { get; set; }

    [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
    public string State { get; set; }
}

public partial class Temperatures
{
    public static Temperatures[] FromJson(string json) => JsonConvert.DeserializeObject<Temperatures[]>(json, ProofOfConcepts.Converter.Settings);
}

public static class Serialize
{
    public static string ToJson(this Temperatures[] self) => JsonConvert.SerializeObject(self, ProofOfConcepts.Converter.Settings);
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
    };
}


public class Geo
{
    // example as http://api.openweathermap.org/geo/1.0/direct?q={city name},{state code},{country code}&limit={limit}&appid={API key}
    public Task<List<Temperatures>> GetGeoDataFirstExampleAsync(string city, string state, string country, int limit, string apiKey)
    {
        
        var q = BuildQ(city, state, country);
        
        var url = $"http://api.openweathermap.org/geo/1.0/direct?q={q}&limit={limit}&appid={apiKey}";
        var client = new HttpClient();
        var response = client.GetAsync(url);
        var content = response.Result.Content.ReadAsStringAsync();
        //var resultPre = JsonConvert.DeserializeObject<List<Temperatures>>(content.Result);
        var result = JsonConvert.DeserializeObject<List<Temperatures>>(content.Result);
        return Task.FromResult(result);
    }
    public string BuildQ(string city, string state, string country)
    {
        var q = string.Empty;
        if(!string.IsNullOrWhiteSpace(city))
        {
            q = $"{city}";
        }
        /*if(string.IsNullOrWhiteSpace(state))
        {
            if(!string.IsNullOrWhiteSpace(q))
            return $"{state}";
        }
        
        
        q = "{city name}";
        q = "{city name},{state code},{country code}";*/
        return q;
    }
    
}