using Plugin.Maui.Audio;
using System.Diagnostics;

namespace _00_MemoryGiorgioCitterio;

public partial class Facile : ContentPage
{
    public int[,] matricePosNumeri = new int[4, 4];
    public int contCarteGir = 0;
    public ImageButton cartaGirata;
    public int coppieTrovate = 0;
    public int mosse = 1;
    public Stopwatch sw = new Stopwatch();
    public int rigaCorrente;
    public int colonnaCorrente;
    public int secondi = 90;
    public bool vittoria = false;
    public bool esegui = true;
    public bool eseguiMusica = false;
    private readonly IAudioManager audioManager;
    private IAudioPlayer player;
    public Facile(IAudioManager audioManager)
	{
		InitializeComponent();
        this.audioManager = audioManager;
        sw.Start();
        Random random = new Random();
        for (int i = 1; i < 9; i++)
        {
            int count = 0;
            while (count < 2)
            {
                int r = random.Next(0, 4);
                int c = random.Next(0, 4);
                if (matricePosNumeri[r, c] == 0)
                {
                    matricePosNumeri[r, c] = i;
                }
                else
                {
                    continue;
                }
                count++;
            }
        }
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            TimeSpan ts = sw.Elapsed;
            Dispatcher.DispatchAsync(async() =>
            {
                secondi -= 1;
                if (secondi == 0 && vittoria == false)
                {
                    player.Stop();
                    await Navigation.PushAsync(new Perso());
                }
                else
                {
                    lblTempo.Text = "Tempo: "+ String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                }
            });
            return true;
        });
    }
    private async void HasClicked(object sender, EventArgs e)
    {
        if (!eseguiMusica)
        {
            Audio();
        }
        if (!esegui)
        {
            return;
        }
        else
            esegui = false;
        if (!(sender is ImageButton))
        {
            return;
        }
        ImageButton image = (ImageButton)sender;
        await image.RotateTo(180, 200);
        image.Rotation = 0;
        switch (SceltaTema.Dati.tema)
        {
            case Tema.Arte:
                image.Source = "arte" + matricePosNumeri[Grid.GetRow(image), Grid.GetColumn(image)].ToString() + ".jpg";
                SceltaTema.Dati.tema = Tema.Arte;
                break;
            case Tema.Supereroi:
                image.Source = "marvel_" + matricePosNumeri[Grid.GetRow(image), Grid.GetColumn(image)].ToString() + ".jpg";
                SceltaTema.Dati.tema = Tema.Supereroi;
                break;
            case Tema.Frutta:
                image.Source = "frutta" + matricePosNumeri[Grid.GetRow(image), Grid.GetColumn(image)].ToString() + ".jpg";
                SceltaTema.Dati.tema = Tema.Frutta;
                break;
            case Tema.Citta:
                image.Source = "cit" + matricePosNumeri[Grid.GetRow(image), Grid.GetColumn(image)].ToString() + ".jpg";
                SceltaTema.Dati.tema = Tema.Citta;
                break;
            default:
                break;
        }
        contCarteGir++;
        lblMosse.Text = "Mosse: " + mosse;
        if (contCarteGir >= 2)
        {
            if (rigaCorrente == Grid.GetRow(image) && colonnaCorrente == Grid.GetColumn(image))
            {
                esegui = true;
                return;
            }
            mosse++;
            await Task.Delay(500);
            if (matricePosNumeri[Grid.GetRow(image), Grid.GetColumn(image)] == matricePosNumeri[Grid.GetRow(cartaGirata), Grid.GetColumn(cartaGirata)])
            {
                contCarteGir = 0;
                image.IsEnabled = false;
                cartaGirata.IsEnabled = false;
                cartaGirata = null;
                coppieTrovate++;
                if (coppieTrovate == 1)
                {
                    player.Stop();
                    vittoria = true;
                    sw.Stop();
                    SceltaTema.Dati.mosseImpiegate = mosse;
                    SceltaTema.Dati.tempoImpiegato = sw.Elapsed;
                    SceltaTema.Dati.data = DateTime.Now;
                    SceltaTema.Dati.difficolta = Difficolta.Facile;
                    await Navigation.PushAsync(new Vittoria());
                }
                lblCoppieTrovate.Text = "Coppie: " + coppieTrovate;
                esegui = true;
                return;
            }
            image.Source = string.Empty;
            cartaGirata.Source = string.Empty;
            contCarteGir = 0;
            esegui = true;
        }
        else
        {
            cartaGirata = image;
            rigaCorrente = Grid.GetRow(image);
            colonnaCorrente = Grid.GetColumn(image);
            esegui = true;
        }
    }
    private async void StopGame(object sender, EventArgs e)
    {
        player.Stop();
        await Navigation.PopAsync();
    }
    private async void ChangeTheme(object sender, EventArgs e)
    {
        player.Stop();
        await Navigation.PopToRootAsync();
    }
    private async void Audio()
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("tetris.mp3"));
        player.Play();
        eseguiMusica = true;
    }
}