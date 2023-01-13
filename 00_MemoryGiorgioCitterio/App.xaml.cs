namespace _00_MemoryGiorgioCitterio;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new SceltaTema());
    }
}
