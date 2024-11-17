using CommunityToolkit.Maui.Core.Extensions;
using LinkedInClone.Models;
using LinkedInClone.Services;
using System.Collections.ObjectModel;

namespace LinkedInClone.ViewModels.Home
{
    public partial class HomeViewModel : BaseViewModel
    {
        private readonly IPostsService _postsService;
        public HomeViewModel(IPostsService postsService)
        {
            _postsService = postsService;
            Posts = _postsService.FetchAll().ToObservableCollection();
        }

        [ObservableProperty]
        private ObservableCollection<Post> posts;
    }
}
