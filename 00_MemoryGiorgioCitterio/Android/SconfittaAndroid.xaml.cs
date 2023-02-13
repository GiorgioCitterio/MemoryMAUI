using _00_MemoryGiorgioCitterio.Model;
namespace _00_MemoryGiorgioCitterio.Android;

public partial class SconfittaAndroid : ContentPage
{
    public SconfittaAndroid()
	{
		InitializeComponent();
    }

    private async void ToHome(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}