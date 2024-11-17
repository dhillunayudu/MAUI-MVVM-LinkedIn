using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClone.IoC
{
    public class ServiceHelper
    {
        public static TService GetService<TService>() => Current.GetService<TService>();

        public static IServiceProvider Current =>
#if ANDROID
MauiApplication.Current.Services;
#elif WINDOWS10_0_17763_0_OR_GREATER
MauiWinUIApplication.Current.Services;
#else
            MauiUIApplicationDelegate.Current.Services;
#endif
    }
}
