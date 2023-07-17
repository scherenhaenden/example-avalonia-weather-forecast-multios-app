using Avalonia.Controls;
using ReactiveUI;
using Weather.Data.Net.Providers.WeatherApi;

namespace WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

public class LocationViewModel: ReactiveObject
{
    
    private LocationModel _locationModel;

    public LocationModel LocationModel
    {
        get => _locationModel;
        set => this.RaiseAndSetIfChanged(ref _locationModel, value);
    }
}