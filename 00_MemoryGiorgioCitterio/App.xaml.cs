namespace _00_MemoryGiorgioCitterio;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            MainPage = new NavigationPage(new SceltaTema());
        }
        else if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            MainPage = new NavigationPage(new Android.SceltaTemaAndroid());
        }
        
    }
}
