﻿namespace _00_MemoryGiorgioCitterio;

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

		return builder.Build();
	}
}
