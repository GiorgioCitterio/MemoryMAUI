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
        var ultimePart = partite.Skip(Math.Max(0, partite.Count() - 3));
        datiList.ItemsSource = ultimePart;
    }
}