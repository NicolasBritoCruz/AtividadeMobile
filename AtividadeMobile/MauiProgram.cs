using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace AtividadeMobile
{
    public static class MauiProgram
    {
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
                    fonts.AddFont("Montserrat-Light.ttf", "Montserrat-Light");
                    fonts.AddFont("Montserrat-SemiBold.ttf", "Montserrat-SemiBold");
                    fonts.AddFont("Montserrat-Bold.ttf", "Montserrat-Bold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
