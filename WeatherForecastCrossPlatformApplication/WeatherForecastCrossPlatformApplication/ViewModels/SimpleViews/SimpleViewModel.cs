using System.Collections.Generic;
using System.Reactive;
using ReactiveUI;

namespace WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

public class WeatherData
{
    public string Location { get; set; }
    public List<WeatherForecast> Forecast { get; set; } = new();
}

public class WeatherForecast
{
    public string Date { get; set; }
    public string Temperature { get; set; }
    public string Description { get; set; }
    // Add more properties as needed
}


public class SimpleViewModel: ReactiveObject
{
    private string location;
    private WeatherData weatherData;

    public string Location
    {
        get => location;
        set => this.RaiseAndSetIfChanged(ref location, value);
    }
    
    public WeatherData WeatherData
    {
        get => weatherData;
        set => this.RaiseAndSetIfChanged(ref weatherData, value);
    }
    
    public SimpleViewModel()
    {
        /*// Initialize services and commands
        var weatherService = new WeatherService(); // Example weather service implementation

        // Example command to fetch weather data
        FetchWeatherCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            WeatherData = await weatherService.GetWeatherDataAsync(Location);
        });*/
    }
    
    public ReactiveCommand<Unit, Unit> FetchWeatherCommand { get; }
}
/*
using Avalonia.Controls;
using ReactiveUI;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WeatherForecastViewModel : ReactiveObject
    {
        private string location;
        private WeatherData weatherData;

        public string Location
        {
            get => location;
            set => this.RaiseAndSetIfChanged(ref location, value);
        }

        public WeatherData WeatherData
        {
            get => weatherData;
            set => this.RaiseAndSetIfChanged(ref weatherData, value);
        }

        public WeatherForecastViewModel()
        {
            // Initialize services and commands
            var weatherService = new WeatherService(); // Example weather service implementation

            // Example command to fetch weather data
            FetchWeatherCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                WeatherData = await weatherService.GetWeatherDataAsync(Location);
            });
        }

        public ReactiveCommand<Unit, Unit> FetchWeatherCommand { get; }
    }
}*/
