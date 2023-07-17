using System.Collections.Generic;

namespace WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

public class WeatherData
{
    public string Location { get; set; }
    public List<WeatherForecast> Forecast { get; set; } = new();
}