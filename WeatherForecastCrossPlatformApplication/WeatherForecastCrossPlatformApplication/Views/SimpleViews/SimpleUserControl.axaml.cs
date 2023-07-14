using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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