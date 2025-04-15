using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;
using scannermaui.Services.interfaces;
using scannermaui.Models;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Alerts;
using scannermaui.Views;

namespace scannermaui.ViewModels
{
    public partial class ScannerViewModel : ObservableObject
    {
        private readonly IApiService _apiService;
        private readonly ICartService _cartService;

        [ObservableProperty]
        private string _result;




        

        public ScannerViewModel(IApiService apiService, ICartService cartService)
        {
            _apiService = apiService;
            _cartService = cartService;
        }

        [RelayCommand]
        private async Task Scan()
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
                    await BarcodeDetected(barcode);
                });
            }
        }

        [RelayCommand]
        private async Task BarcodeDetected(string barcode)
        {
            try
            {
                var response = await _apiService.ScanProductAsync(barcode);

                if (response.StatusCode == 404)
                {
                    bool shouldAdd = await Shell.Current.DisplayAlert(
                        "Product Not Found",
                        "Would you like to add this product?",
                        "Yes", "No");

                    if (shouldAdd)
                    {
                        var popup = new AddProductPopup();
                        var viewModel = new AddProductViewModel(_apiService, popup)
                        {
                            Barcode = barcode 
                        };
                        popup.BindingContext = viewModel;

                        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
                    }
                }
                else if (response.StatusCode == 200 && response.Data != null)
                {
                    var cartItem = new CartItem
                    {
                        ProductName = response.Data.Name,
                        Price = response.Data.Price,
                        Quantity = 1
                    };

                    _cartService.AddToCart(cartItem);
                    await Toast.Make($"{response.Data.Name} added to cart").Show();
                }
                else
                {
                    await Toast.Make(response.Message).Show();
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
