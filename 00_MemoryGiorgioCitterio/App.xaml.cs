namespace _00_MemoryGiorgioCitterio;

public partial class App : Application
{
    public static DatiRepository DatiRepo { get; set; }
	public App(DatiRepository repo)
	{
		InitializeComponent();
        DatiRepo = repo;
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
