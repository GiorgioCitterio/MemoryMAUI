namespace _00_MemoryGiorgioCitterio;
public enum Tema
{
    Arte,
    Supereroi,
    Frutta,
    Citta
}
public enum Difficolta
{
    Facile,
    Medio,
    Difficile
}
public partial class SceltaTema : ContentPage
{ 
	public SceltaTema()
	{
		InitializeComponent();
	}
    public static class Dati
    {
        public static int mosseImpiegate { get; set; }
        public static TimeSpan tempoImpiegato { get; set; }
        public static DateTime data { get; set; }
        public static Tema tema { get; set; }
        public static Difficolta difficolta { get; set; }
    }

    private async void Arte(object sender, EventArgs e)
    {
        Dati.tema = Tema.Arte;
		await Navigation.PushAsync(new MainPage());
    }

    private async void Supereroi(object sender, EventArgs e)
    {
        Dati.tema = Tema.Supereroi;
        await Navigation.PushAsync(new MainPage());
    }

    private async void Frutta(object sender, EventArgs e)
    {
        Dati.tema = Tema.Frutta;
        await Navigation.PushAsync(new MainPage());
    }

    private async void Citta(object sender, EventArgs e)
    {
        Dati.tema = Tema.Citta;
        await Navigation.PushAsync(new MainPage());
    }

    private async void SpiegMem(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://it.wikipedia.org/wiki/Memoria_(gioco)");
    }

    private async void codGit(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/GiorgioCitterio/MemoryMAUI");
    }
}