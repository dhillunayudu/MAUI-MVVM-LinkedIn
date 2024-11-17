using LinkedInClone.Views.Home;

namespace LinkedInClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedHost());
        }
    }
}
