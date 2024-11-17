using LinkedInClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClone.Services
{
    public interface IPostsService
    {
        List<Post> FetchAll();

    }

    public class PostsService : IPostsService
    {
        private List<Post> _posts = new();
        public List<Post> FetchAll()
        {
            _posts = new List<Post>()
            {
                new Post{ Id = 1, Author = new User(){
                    Id = 1,
                    Name = "Dhillu Nayudu",
                    Description = ".Net MAUI Developer" }, Title = "What is .Net MAUI ?",
                    Description = "NET Multi-platform App UI (. NET MAUI) is a cross-platform framework for creating native mobile and desktop apps with C# and XAML. Using . NET MAUI, you can develop apps that can run on Android, iOS, macOS, and Windows from a single shared code-base."
                },
                new Post{ Id = 1, Author = new User(){
                    Id = 1,
                    Name = "Dhillu Nayudu",
                    Description = ".Net MAUI Developer" }, Title = "Xamarin & Xamarin.Forms End of Support",
                    Description = "Xamarin.Android, Xamarin.iOS, Xamarin.Mac are now integrated directly into .NET (starting with .NET 6) as .NET for Android, .NET for iOS, and .NET for Mac. If you're building with these project types today, they should be upgraded to .NET SDK-style projects for continued support.\r\n\r\nXamarin.Forms has evolved into .NET Multi-platform App UI (MAUI) and existing Xamarin.Forms projects should be migrated to .NET MAUI."
                },
                new Post{ Id = 1, Author = new User(){
                    Id = 1,
                    Name = "Dhillu Nayudu",
                    Description = ".Net MAUI Developer" }, Title = "What is Blazor .Net MAUI",
                    Description = "MAUI Blazor Hybrid is an evolution of Xamarin. Forms, a framework for building native mobile and desktop applications using C#. With MAUI, developers can create native user interfaces using a single codebase that runs on multiple platforms, such as iOS, Android, macOS, and Windows."
                }
            };
            return _posts;
        }
    }
}
