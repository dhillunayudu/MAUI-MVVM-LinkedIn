using CommunityToolkit.Maui;
using LinkedInClone.IoC;
using Microsoft.Extensions.Logging;
using MauiIcons.Material;

namespace LinkedInClone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMaterialMauiIcons()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // REGISTER DEPENDENCIES
            Dependencies.Register(builder.Services);

            Microsoft.Maui.Handlers.ToolbarHandler.Mapper.AppendToMapping("CustomNavigationView", (handler, view) =>
            {
#if ANDROID
        handler.PlatformView.ContentInsetStartWithNavigation = 0;
        handler.PlatformView.SetContentInsetsAbsolute(0, 0);
#endif
            });

#if DEBUG
            builder.Logging.AddDebug();
#endif

           

            return builder.Build();
        }
    }
}
