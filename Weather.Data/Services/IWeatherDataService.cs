using Weather.Data.Net.Providers.WeatherApi;

namespace Weather.Data.Services;

public interface IWeatherDataService
{
    public Task<TemperaturesResponseModel> GetCurrentWeatherData(string location);
}

public class WeatherDataService: IWeatherDataService
{
    private readonly ApiCom _apiCom;

    public WeatherDataService(ApiCom apiCom)
    {
        _apiCom = apiCom;
    }
    
    // using ApiCom


    public Task<TemperaturesResponseModel> GetCurrentWeatherData(string location)
    {
        return _apiCom.GetCurrent(location, true, true);
    }
}