using MyMauiApp.ViewModels;

namespace MyMauiApp.Views;

public partial class DeviceListPage : ContentPage
{
	DeviceListViewModel model;
	public DeviceListPage(DeviceListViewModel model)
	{
		InitializeComponent();
		this.model = model;
		this.model.GetAllAsync();
		this.BindingContext = model;
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync(nameof(AddDevicePage));
    }
}