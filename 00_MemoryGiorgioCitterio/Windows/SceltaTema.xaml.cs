using _00_MemoryGiorgioCitterio.Model;
namespace _00_MemoryGiorgioCitterio;
public partial class SceltaTema : ContentPage
{ 
    public static Dati dato = new Dati();
	public SceltaTema()
	{
		InitializeComponent();
	}

    private async void Arte(object sender, EventArgs e)
    {
        dato.Tema = Tema.Arte;
		await Navigation.PushAsync(new MainPage());
    }

    private async void Supereroi(object sender, EventArgs e)
    {
        dato.Tema = Tema.Supereroi;
        await Navigation.PushAsync(new MainPage());
    }

    private async void Frutta(object sender, EventArgs e)
    {
        dato.Tema = Tema.Frutta;
        await Navigation.PushAsync(new MainPage());
    }

    private async void Citta(object sender, EventArgs e)
    {
        dato.Tema = Tema.Citta;
        await Navigation.PushAsync(new MainPage());
    }

    private async void SpiegMem(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://it.wikipedia.org/wiki/Memoria_(gioco)");
    }

    private async void Impostazioni(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Windows.ImpostazioniWindows());
    }
}