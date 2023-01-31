namespace _00_MemoryGiorgioCitterio.Android;

public partial class VittoriaAndroid : ContentPage
{
    public static List<DatiAndroid> listaDati = new List<DatiAndroid>(5);
    public DatiAndroid datoCorrente = new DatiAndroid();
    public VittoriaAndroid()
	{
		InitializeComponent();
        datoCorrente.data = SceltaTemaAndroid.DatiAndroid.data;
        datoCorrente.mosseImpiegate = SceltaTemaAndroid.DatiAndroid.mosseImpiegate;
        datoCorrente.tempoImpiegato = SceltaTemaAndroid.DatiAndroid.tempoImpiegato;
        datoCorrente.tema = SceltaTemaAndroid.DatiAndroid.tema;
        datoCorrente.difficolta = SceltaTemaAndroid.DatiAndroid.difficolta;
        listaDati.Add(datoCorrente);
        listaDati.Sort((d1, d2) => DateTime.Compare(d1.data, d2.data));
        listaDati.Reverse();
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
    public class DatiAndroid
    {
        public int mosseImpiegate { get; set; }
        public TimeSpan tempoImpiegato { get; set; }
        public DateTime data { get; set; }
        public TemaAndroid tema { get; set; }
        public DifficoltaAndroid difficolta { get; set; }
    }
}