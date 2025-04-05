using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Alerts;
using scannermaui.Models;
using scannermaui.Services.interfaces;

namespace scannermaui.ViewModels
{
    public partial class ProductDetailsViewModel : ObservableObject, IQueryAttributable
    {
        private readonly ICartService _cartService;

        [ObservableProperty]
        private Product _product;

        [ObservableProperty]
        private bool _isBusy;

        public ProductDetailsViewModel(ICartService cartService)
        {
            _cartService = cartService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("Product"))
            {
                Product = query["Product"] as Product;
            }
        }

        [RelayCommand]
        private async Task AddToCart()
        {
            try
            {
                IsBusy = true;

                var cartItem = new CartItem
                {
                    ProductName = Product.Name,
                    Price = Product.Price,
                    Quantity = 1
                };

                _cartService.AddToCart(cartItem);

                var toast = Toast.Make($"{Product.Name} added to cart", CommunityToolkit.Maui.Core.ToastDuration.Short);
                await toast.Show();

                await Shell.Current.GoToAsync("//CartPage");

            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}