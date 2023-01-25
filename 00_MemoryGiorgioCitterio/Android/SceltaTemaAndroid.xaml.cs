namespace _00_MemoryGiorgioCitterio.Android;
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
public partial class SceltaTemaAndroid : ContentPage
{
	public SceltaTemaAndroid()
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
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Supereroi(object sender, EventArgs e)
    {
        Dati.tema = Tema.Supereroi;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Frutta(object sender, EventArgs e)
    {
        Dati.tema = Tema.Frutta;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }

    private async void Citta(object sender, EventArgs e)
    {
        Dati.tema = Tema.Citta;
        await Navigation.PushAsync(new SceltaDifficoltaAndroid());
    }
}