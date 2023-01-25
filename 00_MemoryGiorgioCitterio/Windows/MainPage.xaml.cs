namespace _00_MemoryGiorgioCitterio;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

    private async void Facile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Facile());
    }

    private async void Medio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Medio());
    }

    private async void Difficile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Difficile());
    }
}

