using Weather.Data.Net.Providers.WeatherApi;
using Weather.Data.Services;

namespace Weather.Business.Services.WeatherInformation;

public interface IWeatherService
{
    // Decide which service to use
    // Get weather current data for a location
    public Task<TemperaturesResponseModel> GetCurrentWeatherData(string location);
}

public class WeatherService: IWeatherService
{
    private readonly IWeatherDataService _weatherDataService;

    public WeatherService(IWeatherDataService weatherDataService)
    {
        _weatherDataService = weatherDataService;
    }
    
    public WeatherService()
    {
        _weatherDataService = new WeatherDataService(new ApiCom("https://api.weatherapi.com/v1", "8663e373364c40f7971133602231607"));
    }
    
    public WeatherService(ApiCom apiCom)
    {
        _weatherDataService = new WeatherDataService(apiCom);
    }
  
    
    public Task<TemperaturesResponseModel> GetCurrentWeatherData(string location)
    {
        return _weatherDataService.GetCurrentWeatherData(location);
    }
}