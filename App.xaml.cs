using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using scannermaui.ViewModels;
using scannermaui.Views;

namespace scannermaui
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
     
            InitializeComponent();

            var token = SecureStorage.Default.GetAsync("UserToken").Result;

            if (!string.IsNullOrEmpty(token))
            {
                MainPage = serviceProvider.GetRequiredService<AppShell>();
            }
            else
            {
                MainPage = new NavigationPage(serviceProvider.GetRequiredService<LoginPage>());
            }
        }
    }
}