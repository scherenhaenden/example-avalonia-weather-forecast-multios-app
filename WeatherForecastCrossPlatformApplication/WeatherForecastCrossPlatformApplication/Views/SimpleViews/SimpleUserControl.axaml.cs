using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

namespace WeatherForecastCrossPlatformApplication.Views.SimpleViews;

public partial class SimpleUserControl : UserControl
{
    public SimpleUserControl()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}