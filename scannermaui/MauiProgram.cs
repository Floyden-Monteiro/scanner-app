using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using scannermaui.Services;
using scannermaui.Services.interfaces;
using scannermaui.Services.Interfaces;
using scannermaui.ViewModels;
using scannermaui.Views;
using ZXing.Net.Maui.Controls;

namespace scannermaui
{
    public static class MauiProgram
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit()
                .UseBarcodeReader();

            // Register services
            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddSingleton<ICartService, CartService>();
            builder.Services.AddSingleton<IApiService, ApiService>();
            builder.Services.AddSingleton<PrintService>();
            builder.Services.AddSingleton<IStorageService, StorageService>();
            builder.Services.AddTransient<CartService>();

            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<CartViewModel>();
            builder.Services.AddTransient<ScannerViewModel>();
            builder.Services.AddTransient<SearchViewModel>();
            builder.Services.AddTransient<ProductDetailsViewModel>();
            builder.Services.AddTransient<AddProductViewModel>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<CartPage>();
            builder.Services.AddTransient<ScannerPage>();
            builder.Services.AddTransient<SearchPage>();
            builder.Services.AddTransient<ProductDetailsPage>();
            builder.Services.AddTransient<AddProductPopup>();
            builder.Services.AddTransient<AppShell>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            var app = builder.Build();
            ServiceProvider = app.Services;
            return app;
        }
    }
}