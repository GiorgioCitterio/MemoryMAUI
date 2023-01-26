namespace _00_MemoryGiorgioCitterio.Android;

public partial class VittoriaAndroid : ContentPage
{
	public VittoriaAndroid()
	{
		InitializeComponent();
	}

    private async void ToHome(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}