namespace _00_MemoryGiorgioCitterio.Android;
public enum TemaAndroid
{
    Arte,
    Supereroi,
    Frutta,
    Citta
}
public enum DifficoltaAndroid
{
    Facile,
    Medio,
    Difficile
}
public partial class SceltaTemaAndroid : ContentPage
{
	public SceltaTemaAndroid()
	{
		InitializeComponent();
	}

    public static class DatiAndroid
    {
        public static int mosseImpiegate { get; set; }
        public static TimeSpan tempoImpiegato { get; set; }
        public static DateTime data { get; set; }
        public static TemaAndroid tema { get; set; }
        public static DifficoltaAndroid difficolta { get; set; }
    }

    private async void Arte(object sender, EventArgs e)
    {
        DatiAndroid.tema = TemaAndroid.Arte;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Supereroi(object sender, EventArgs e)
    {
        DatiAndroid.tema = TemaAndroid.Supereroi;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Frutta(object sender, EventArgs e)
    {
        DatiAndroid.tema = TemaAndroid.Frutta;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Citta(object sender, EventArgs e)
    {
        DatiAndroid.tema = TemaAndroid.Citta;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
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