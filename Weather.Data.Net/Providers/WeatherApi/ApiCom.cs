using Newtonsoft.Json;

namespace Weather.Data.Net.Providers.WeatherApi;

public class ApiCom
{
    private readonly string _baseUrl;
    private readonly string _key;

    public ApiCom(string baseUrl, string key)
    {
        _baseUrl = baseUrl;
        _key = key;
    }
    
    /*
     *
     * Current weather	/current.json or /current.xml
Forecast	/forecast.json or /forecast.xml
Search or Autocomplete	/search.json or /search.xml
History	/history.json or /history.xml
Marine	/marine.json or /marine.xml
Future	/future.json or /future.xml
Time Zone	/timezone.json or /timezone.xml
Sports	/sports.json or /sports.xml
Astronomy	/astronomy.json or /astronomy.xml
IP Lookup	/ip.json or /ip.xml
     */

    public Task<TemperaturesResponseModel> GetCurrent(string city, bool aqi, bool json = true)
    {
        var currentUrl = _baseUrl + "/current." + (json ? "json" : "xml");
        
        currentUrl += "?key=" + _key;
        
        currentUrl += $"&q={city}";
        
        currentUrl += $"&aqi={(aqi ? "yes" : "no")}";
        
        var client = new HttpClient();
        
        var response = client.GetAsync(currentUrl);
        response.Wait();
        var result = response.Result;
        var content = result.Content.ReadAsStringAsync();
        content.Wait();
        var values = content.Result;
        var temps = JsonConvert.DeserializeObject<TemperaturesResponseModel>(values);
        return Task.FromResult(temps);
    }

    private string BuildQueryRequest(string city,
        bool aqi,
        int days)
    {
        return "    ";
    }
        
    

}