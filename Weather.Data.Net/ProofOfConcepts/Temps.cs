using Newtonsoft.Json;

namespace Weather.Data.Net.ProofOfConcepts;

public class Temps
{
    // https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={part}&appid={API key}
    public Task<object> GetTemps(string lat, string lon, string part, string apiKey)
    {
        var url = $"https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={part}&appid={apiKey}";
        var client = new HttpClient();
        var response = client.GetAsync(url);
        response.Wait();
        var result = response.Result;
        var content = result.Content.ReadAsStringAsync();
        content.Wait();
        var values = content.Result;
        var temps = JsonConvert.DeserializeObject<object>(values);
        return Task.FromResult(temps);
    }
}