using LinkedInClone.Views;
using LinkedInClone.Views.Home;

namespace LinkedInClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage(); //new NavigationPage(new TabbedHost());
        }
    }
}
