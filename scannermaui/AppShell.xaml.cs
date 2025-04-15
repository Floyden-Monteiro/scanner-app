using Microsoft.Maui.Controls;
using scannermaui.Services.interfaces;
using scannermaui.Views;

namespace scannermaui
{
    public partial class AppShell : Shell
    {
        private readonly IAuthService _authService;

        public AppShell(IAuthService authService)
        {
            InitializeComponent();
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("ProductDetails", typeof(ProductDetailsPage));
            _authService = authService;
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            bool confirm = await Application.Current.MainPage.DisplayAlert("Logout", "Are you sure you want to logout?", "Yes", "No");

            if (confirm)
            {
                await _authService.Logout();
                var loginPage = MauiProgram.ServiceProvider.GetRequiredService<LoginPage>();
                Application.Current.MainPage = new NavigationPage(loginPage);
            }
        }
    }
}