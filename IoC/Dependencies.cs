using CommunityToolkit.Maui;
using LinkedInClone.Services;
using LinkedInClone.ViewModels.Home;
using LinkedInClone.Views;

namespace LinkedInClone.IoC
{
    public class Dependencies
    {
        public static void Register(IServiceCollection services)
        {
            #region Services
            services.AddTransient<IPostsService, PostsService>();
            #endregion


            #region ViewModels
            services.AddTransient<HomeViewModel>();
            #endregion

            #region Views
            services.AddTransient<HomePage>(); 
            #endregion

        }
    }
}
