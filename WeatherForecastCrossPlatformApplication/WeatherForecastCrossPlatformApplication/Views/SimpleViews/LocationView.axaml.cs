using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Weather.Data.Net.Providers.WeatherApi;
using WeatherForecastCrossPlatformApplication.ViewModels.SimpleViews;

namespace WeatherForecastCrossPlatformApplication.Views.SimpleViews;

public partial class LocationView : UserControl
{
    public static readonly StyledProperty<LocationModel> LocationModelProperty = AvaloniaProperty.Register<LocationView, LocationModel>("LocationModel");

    /*private LocationModel _LocationModel;
    public static readonly DirectProperty<LocationView, dynamic> LocationModelProperty = AvaloniaProperty.RegisterDirect<LocationView, dynamic>("LocationModel", o => o.LocationModel, (o, v) => o.LocationModel = v);
*/
    public LocationView()
    {
        InitializeComponent();
        //DataContext = new LocationViewModel();
    }

    public LocationModel LocationModel
    {
        get { return (LocationModel)GetValue(LocationModelProperty); }
        set { SetValue(LocationModelProperty, value); }
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}