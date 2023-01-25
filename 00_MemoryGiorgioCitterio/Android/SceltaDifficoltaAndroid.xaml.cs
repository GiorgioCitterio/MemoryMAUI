namespace _00_MemoryGiorgioCitterio.Android;

public partial class SceltaDifficoltaAndroid : ContentPage
{
	public SceltaDifficoltaAndroid()
	{
		InitializeComponent();
	}

    private async void Facile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FacileAndroid());
    }

    private async void Medio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MedioAndroid());
    }

    private async void Difficile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DifficileAndroid());
    }
}