using CommunityToolkit.Maui;
using firstui.Pages;
using firstui.Services;
using Microsoft.Extensions.Logging;

namespace firstui
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
                    fonts.AddFont("Poppins-Regular", "PoppinsRegular");
                    fonts.AddFont("Poppins-Semibold.ttf", "PoppinsSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddHttpClient(ApiService.httpClientName,
                httpClient => httpClient.BaseAddress = new Uri("https://api.themoviedb.org"));

            builder.Services.AddSingleton<ApiService>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }


        //
        //eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwNWZhZTg3NWJhODI1YWYyODFiY2IwYTU1ODMwNzFlMSIsIm5iZiI6MTczMDc1MDA4My40MzI2NDU2LCJzdWIiOiI2NDU5YWVkZmFlMzg0MzAwZmVmNTUxYmIiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.M6ve7UJ34W72j53JGmyhyeiGWCJvY73xKQ-V8smBcvI
    }
}
