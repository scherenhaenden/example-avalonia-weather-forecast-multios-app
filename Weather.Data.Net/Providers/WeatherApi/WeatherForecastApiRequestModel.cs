namespace Weather.Data.Net.Providers.WeatherApi;

public class WeatherForecastApiRequestModel: WeatherApiRequestModel
{
    public int Days { get; set; }
}