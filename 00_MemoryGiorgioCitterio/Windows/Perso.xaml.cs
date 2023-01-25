namespace _00_MemoryGiorgioCitterio;

public partial class Perso : ContentPage
{
    public static List<Vittoria.Dati> listaDati = Vittoria.listaDati;
    public Perso()
	{
		InitializeComponent();
        for (int i = 0; i < listaDati.Count; i++)
        {
            switch (i)
            {
                case 0:
                    lbl1.Text += ("Tema: " + listaDati[i].tema + " - " + " Difficoltà: " + listaDati[i].difficolta + " - " + " Data: " + listaDati[i].data.ToString() + " - " + " Mosse: " + listaDati[i].mosseImpiegate.ToString() + " - " + " Tempo impiegato: " + listaDati[i].tempoImpiegato.ToString());
                    break;
                case 1:
                    lbl2.Text += ("Tema: " + listaDati[i].tema + " - " + " Difficoltà: " + listaDati[i].difficolta + " - " + " Data: " + listaDati[i].data.ToString() + " - " + " Mosse: " + listaDati[i].mosseImpiegate.ToString() + " - " + " Tempo impiegato: " + listaDati[i].tempoImpiegato.ToString());
                    break;
                case 2:
                    lbl3.Text += ("Tema: " + listaDati[i].tema + " - " + " Difficoltà: " + listaDati[i].difficolta + " - " + " Data: " + listaDati[i].data.ToString() + " - " + " Mosse: " + listaDati[i].mosseImpiegate.ToString() + " - " + " Tempo impiegato: " + listaDati[i].tempoImpiegato.ToString());
                    break;
                case 3:
                    lbl4.Text += ("Tema: " + listaDati[i].tema + " - " + " Difficoltà: " + listaDati[i].difficolta + " - " + " Data: " + listaDati[i].data.ToString() + " - " + " Mosse: " + listaDati[i].mosseImpiegate.ToString() + " - " + " Tempo impiegato: " + listaDati[i].tempoImpiegato.ToString());
                    break;
                case 4:
                    lbl5.Text += ("Tema: " + listaDati[i].tema + " - " + " Difficoltà: " + listaDati[i].difficolta + " - " + " Data: " + listaDati[i].data.ToString() + " - " + " Mosse: " + listaDati[i].mosseImpiegate.ToString() + " - " + " Tempo impiegato: " + listaDati[i].tempoImpiegato.ToString());
                    break;
                default:
                    break;
            }
        }
    }

    private async void ToHome(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}