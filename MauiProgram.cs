﻿using Microsoft.Extensions.Logging;
using Simplz.Speedometer.Services;

namespace Simplz.Speedometer
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

#if ANDROID
        builder.Services.AddSingleton<ILocationService, LocationService>();
#endif

            return builder.Build();
        }
    }
}