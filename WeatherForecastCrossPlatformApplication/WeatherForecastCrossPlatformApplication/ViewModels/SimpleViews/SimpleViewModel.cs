using System.Reactive;
using ReactiveUI;
using Weather.Business.Services.WeatherInformation;
using Weather.Data.Net.Providers.WeatherApi;

namespace WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

public class SimpleViewModel: ReactiveObject
{
    private string _location;
    private WeatherData _weatherData;
    private TemperaturesResponseModel _weatherDataText;
    private LocationViewModel _locationViewModel;

    public string Location
    {
        get => _location;
        set => this.RaiseAndSetIfChanged(ref _location, value);
    }
    
    public WeatherData WeatherData
    {
        get => _weatherData;
        set => this.RaiseAndSetIfChanged(ref _weatherData, value);
    }
    
    public TemperaturesResponseModel WeatherDataText
    {
        get => _weatherDataText;
        set => this.RaiseAndSetIfChanged(ref _weatherDataText, value);
    }
    
    public LocationViewModel LocationViewModelData
    {
        get => _locationViewModel;
        set => this.RaiseAndSetIfChanged(ref _locationViewModel, value);
    }
    
    public SimpleViewModel()
    {
        
        LocationViewModelData = new LocationViewModel();
        
        /// Initialize services and commands
        IWeatherService weatherService = new WeatherService(); // Example weather service implementation

        // Example command to fetch weather data
        FetchWeatherCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            WeatherDataText = await weatherService.GetCurrentWeatherData(Location);
            LocationViewModelData.LocationModel = WeatherDataText.LocationModel;
        });
    }
    
    public ReactiveCommand<Unit, Unit> FetchWeatherCommand { get; }
}