using BijlesPA.Repos;
using BijlesPA.ViewModels;
using Microsoft.Extensions.Logging;

namespace BijlesPA;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		// Registreren van dependencies doen we hier
		builder.Services.AddSingleton<IVideoGameRepo, VideoGameRepo>();
		builder.Services.AddSingleton<MainVM>();
		return builder.Build();
	}
}
