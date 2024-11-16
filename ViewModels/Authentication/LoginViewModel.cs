using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace LinkedInClone.ViewModels.Authentication
{
    public partial class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
        }

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [RelayCommand]
        private async Task SignIn()
        {
            var validationResult = Validate();
            if (validationResult.Item1)
            {
                // TODO : Navigate to home page
            }
            else
            {
                await ShowSnackbarError(validationResult.Item2);
            }
            
        }

        private (bool,string) Validate()
        {
            if (string.IsNullOrEmpty(Username))
            {
                return (false,"Please enter a valid username.");
            }

            if (string.IsNullOrEmpty(Password))
            {
                return (false, "Please enter your password.");
            }

            // TODO: Validate user 
            return (true,"Success");
        }

        private async Task ShowSnackbarError(string message)
        {
            var snackbar = Snackbar.Make("Please enter a valid Username.");
            await snackbar.Show();
        }
    }
}
