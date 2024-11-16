using Android.App;
using Android.Runtime;

namespace LinkedInClone
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp()
        {
            #region Handlers

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.Background = null;
                //SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif
            });

            #endregion

            return MauiProgram.CreateMauiApp();
        }
    }
}
