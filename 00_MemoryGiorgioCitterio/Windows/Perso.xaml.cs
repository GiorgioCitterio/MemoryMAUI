namespace _00_MemoryGiorgioCitterio;

public partial class Perso : ContentPage
{
    public Perso()
	{
		InitializeComponent();
    }

    private async void ToHome(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}