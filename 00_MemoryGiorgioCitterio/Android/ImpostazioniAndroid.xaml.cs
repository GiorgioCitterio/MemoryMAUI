namespace _00_MemoryGiorgioCitterio.Android;

public partial class ImpostazioniAndroid : ContentPage
{
    public static bool musicEnable = true;
	public ImpostazioniAndroid()
	{
		InitializeComponent();
	}
    private async void codGit(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/GiorgioCitterio/MemoryMAUI");
    }

    private void MusicControl(object sender, EventArgs e)
    {
        Color currentColor1;
        if(sender == btn_off)
        {
            btn_off.IsEnabled = false;
            btn_off.BackgroundColor = Color.FromRgb(173, 216, 230);
            musicEnable = false;
            if (!btn_on.IsEnabled)
            {
                btn_on.IsEnabled = true;
                btn_on.BackgroundColor = Color.FromRgb(0, 0, 255);
            }
        }
        else if(sender == btn_on) 
        {
            btn_on.IsEnabled = false;
            btn_on.BackgroundColor = Color.FromRgb(173, 216, 230);
            musicEnable = true;
            if (!btn_off.IsEnabled)
            {
                btn_off.IsEnabled = true;
                btn_off.BackgroundColor = Color.FromRgb(0, 0, 255);
            }
        }
    }
}