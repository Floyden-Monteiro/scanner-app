using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;
using scannermaui.Services.interfaces;
using scannermaui.Models;

namespace scannermaui.ViewModels
{
    public partial class ScannerViewModel : ObservableObject
    {
        private readonly ICartService _cartService;
        private readonly IApiService _apiService;

        public ScannerViewModel(ICartService cartService, IApiService apiService)
        {
            _cartService = cartService;
            _apiService = apiService;
        }

        [RelayCommand]
        private async void Scan()
        {
            var cameraBarcodeReaderView = new CameraBarcodeReaderView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Options = new BarcodeReaderOptions
                {
                    AutoRotate = true,
                    Multiple = false,
                }

            };

            cameraBarcodeReaderView.BarcodesDetected += OnBarcodesDetected;

            var scanPage = new ContentPage
            {
                Content = new Grid
                {
                    Children = { cameraBarcodeReaderView }
                }
            };

            await Shell.Current.Navigation.PushAsync(scanPage);
            cameraBarcodeReaderView.IsDetecting = true;
        }

        private async void OnBarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            if (e.Results?.Any() == true)
            {
                var barcode = e.Results.First().Value;

                if (sender is CameraBarcodeReaderView camera)
                {
                    camera.IsDetecting = false;
                }

                await MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    await Shell.Current.Navigation.PopAsync();

                    try
                    {
                        var response = await _apiService.ScanProductAsync(barcode);

                        if (response.StatusCode == 200)
                        {
                            var cartItem = new CartItem
                            {
                                ProductName = response.Data.Name,
                                Price = response.Data.Price,
                                Quantity = 1
                            };

                            _cartService.AddToCart(cartItem);
                            await Shell.Current.GoToAsync("//CartPage");
                        }
                        else if (response.StatusCode == 404)
                        {
                            await Shell.Current.DisplayAlert("Not Found", "Product not found in database", "OK");
                            await Shell.Current.GoToAsync("//ScannerPage");
                        }
                    }
                    catch (Exception ex)
                    {
                        await Shell.Current.DisplayAlert("Error", "Failed to scan product", "OK");
                        await Shell.Current.GoToAsync("//ScannerPage");
                    }
                });
            }
        }
    }
}
