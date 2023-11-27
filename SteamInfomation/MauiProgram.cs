using Microsoft.Extensions.Logging;

namespace SteamInfomation;

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
				fonts.AddFont("SairaExtraCondensed-Bold.ttf", "SairaExtraCondensedbold");
                fonts.AddFont("SairaExtraCondensed-Regular.ttf", "SairaExtraCondensedRegular");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
