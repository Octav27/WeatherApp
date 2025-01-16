using Microsoft.Extensions.Logging;

namespace WeatherApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {


            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Kanit-Regular.ttf", "KanitRegular");
                    fonts.AddFont("Kanit-Medium.ttf", "KanitMedium");
                    fonts.AddFont("Kanit-Black.ttf", "KanitBlack");
                    fonts.AddFont("Kanit-Bold.ttf", "KanitBold");
                    fonts.AddFont("Kanit-Italic.ttf", "KanitItalic");
                    fonts.AddFont("Kanit-Semibold.ttf", "KanitSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
