using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using scannermaui.Services.interfaces;
using scannermaui.Views;
using Microsoft.Maui.Storage;

namespace scannermaui.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;

        public LoginViewModel(IAuthService authService, IServiceProvider serviceProvider)
        {
            _authService = authService;
            _serviceProvider = serviceProvider;
        }

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _isErrorVisible;

        [ObservableProperty]
        private bool _isBusy;

        [RelayCommand]
        private async Task Login()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Username and password are required.";
                IsErrorVisible = true;
                return;
            }

            try
            {
                IsBusy = true;
                IsErrorVisible = false;

                var token = await _authService.Login(Username, Password);
                if (!string.IsNullOrEmpty(token))
                {
                    await SecureStorage.SetAsync("UserToken", token);

                    var appShell = _serviceProvider.GetService<AppShell>();
                    Application.Current.MainPage = appShell;
                }
                else
                {
                    ErrorMessage = "Invalid username or password.";
                    IsErrorVisible = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "An error occurred during login.";
                IsErrorVisible = true;
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task Logout()
        {
            try
            {
                IsBusy = true;

                await Task.Run(() =>
                {
                    SecureStorage.Remove("UserToken");
                });

                Application.Current.MainPage = new NavigationPage(_serviceProvider.GetRequiredService<LoginPage>());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
