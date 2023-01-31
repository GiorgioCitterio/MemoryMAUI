namespace _00_MemoryGiorgioCitterio.Windows;

public partial class ImpostazioniWindows : ContentPage
{
	public ImpostazioniWindows()
	{
		InitializeComponent();
	}
    private async void codGit(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/GiorgioCitterio/MemoryMAUI");
    }
}