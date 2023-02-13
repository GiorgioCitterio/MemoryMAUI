using Plugin.Maui.Audio;

namespace _00_MemoryGiorgioCitterio;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("times new roman.ttf", "TimesNewRoman");
                fonts.AddFont("FiraSans-Bold.otf", "FiraSansBold");
                fonts.AddFont("Purple Smile.ttf", "PurpleSmile");
                fonts.AddFont("Requiem.ttf", "Requiem");
                fonts.AddFont("Low Budget.ttf", "LowBudget");
            });
		builder.Services.AddSingleton(AudioManager.Current);
		builder.Services.AddTransient<Facile>();

        string dbPath = FileAccessHelper.GetFileLocalPath("Dati.db3"); //prendo percorso del db
        builder.Services.AddSingleton<DatiRepository>(s => ActivatorUtilities.CreateInstance<DatiRepository>(s, dbPath));
        return builder.Build();
	}
}
