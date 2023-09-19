using MyMauiApp.Views;

namespace MyMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(DeviceListPage), typeof(DeviceListPage));
        Routing.RegisterRoute(nameof(AddDevicePage), typeof(AddDevicePage));
        Routing.RegisterRoute(nameof(EditDevicePage), typeof(EditDevicePage));
        
       
       
    }
}
