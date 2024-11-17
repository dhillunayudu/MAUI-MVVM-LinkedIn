using LinkedInClone.IoC;
using LinkedInClone.ViewModels.Home;

namespace LinkedInClone.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = ServiceHelper.GetService<HomeViewModel>();
    }
    public HomePage(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}