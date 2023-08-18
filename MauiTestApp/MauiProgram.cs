using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;


namespace MauiTestApp;

public static class MauiProgram
{
	//public static SimpleLogger.ILogger TheLogger;

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		//TheLogger= new SimpleLogger.Logger("testlog.txt");

		return builder.Build();
	}
}
