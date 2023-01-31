namespace _00_MemoryGiorgioCitterio.Android;

public partial class ImpostazioniAndroid : ContentPage
{
	public ImpostazioniAndroid()
	{
		InitializeComponent();
	}
    private async void codGit(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/GiorgioCitterio/MemoryMAUI");
    }
}