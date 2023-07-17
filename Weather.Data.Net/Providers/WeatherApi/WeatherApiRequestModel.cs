namespace Weather.Data.Net.Providers.WeatherApi;

public class WeatherApiRequestModel
{
    public string City { get; set; }
    public bool Aqi { get; set; }
    public string Unixdt { get; set; }
    public LanguageCode Language { get; set; }
}