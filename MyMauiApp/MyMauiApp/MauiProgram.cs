using Microsoft.Extensions.Logging;
using MyMauiApp.ViewModels;
using MyMauiApp.Views;

namespace MyMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton(typeof(IFilePicker), FilePicker.Default);
        builder.Services.AddSingleton(typeof(DeviceListViewModel));
        builder.Services.AddSingleton(typeof(SpecListViewModel));
        builder.Services.AddSingleton(typeof(AddDevicePage));
        builder.Services.AddSingleton(typeof(EditDevicePage));
        builder.Services.AddSingleton(typeof(DeviceListPage));
       
       
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
