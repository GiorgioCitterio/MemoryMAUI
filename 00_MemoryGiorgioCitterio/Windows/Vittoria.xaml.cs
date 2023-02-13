using _00_MemoryGiorgioCitterio.Model;

namespace _00_MemoryGiorgioCitterio;

public partial class Vittoria : ContentPage
{
    public Vittoria()
	{
		InitializeComponent();
        
    }
    private async void ToHome(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }

    private async void GetPartite_Clicked(object sender, EventArgs e)
    {
        List<Dati> partite = await App.DatiRepo.GetAllPartite();
        List<Dati> ultimePart = new List<Dati>(5);
        ultimePart = partite;
        datiList.ItemsSource = ultimePart;
    }
}