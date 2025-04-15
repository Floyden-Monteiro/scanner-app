using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using scannermaui.Models;
using scannermaui.Services.interfaces;
using System.Linq;
using scannermaui.Services;
using CommunityToolkit.Maui.Alerts;

namespace scannermaui.ViewModels
{
    public partial class CartViewModel : ObservableObject
    {
        private readonly ICartService _cartService;
        private readonly PrintService _printService;

        public ObservableCollection<CartItem> CartItems { get; }

        [ObservableProperty]
        private int _totalQuantity;

        [ObservableProperty]
        private decimal _totalAmount;

        public CartViewModel(ICartService cartService, PrintService printService)
        {
            _cartService = cartService;
            _printService = printService;
            CartItems = _cartService.GetCartItems();


            _cartService.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(ICartService.TotalQuantity))
                    TotalQuantity = _cartService.TotalQuantity;
                else if (e.PropertyName == nameof(ICartService.TotalAmount))
                    TotalAmount = _cartService.TotalAmount;
            };


            TotalQuantity = _cartService.TotalQuantity;
            TotalAmount = _cartService.TotalAmount;
        }

        private void UpdateTotals()
        {

            TotalQuantity = CartItems.Sum(item => item.Quantity);
            TotalAmount = CartItems.Sum(item => item.Price * item.Quantity);
            OnPropertyChanged(nameof(CartItems));
        }

        [RelayCommand]
        public void AddToCart(CartItem item)
        {
            if (item != null)
            {
                _cartService.AddToCart(item);
                UpdateTotals();
            }
        }

        [RelayCommand]
        private void IncreaseQuantity(CartItem item)
        {
            if (item != null)
            {
                item.Quantity++;
                _cartService.SaveCartItems();
            }
        }

        [RelayCommand]
        public async Task DecreaseQuantity(CartItem item)
        {
            if (item == null) return;

            if (item.Quantity > 1)
            {
                item.Quantity--;
                _cartService.SaveCartItems();
            }
            else
            {
                bool confirm = await Shell.Current.DisplayAlert(
                    "Confirm",
                    $"Do you want to remove HotReload {item.ProductName}?",
                    "Yes",
                    "No");

                if (confirm)
                {
                    _cartService.RemoveFromCart(item);
                    UpdateTotals();
                }
            }
        }

        [RelayCommand]
        public async Task RemoveFromCart(CartItem item)
        {
            if (item == null) return;

            bool confirm = await Shell.Current.DisplayAlert(
                "Remove Item",
                $"Are you sure you want to remove {item.ProductName} from the cart?",
                "Yes",
                "No");

            if (confirm)
            {
                _cartService.RemoveFromCart(item);
                OnPropertyChanged(nameof(CartItems));
            }
        }

        [RelayCommand]
        private async Task ShareInvoice()
        {
            if (CartItems == null || !CartItems.Any())
            {
                await Shell.Current.DisplayAlert("Error", "Cart is empty", "OK");
                return;
            }

            try
            {
                await _printService.HandleInvoice(CartItems.ToList(), TotalAmount, true);
                // await Toast.Make("Invoice shared successfully").Show();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Failed to share: {ex.Message}", "OK");
            }
        }

        [RelayCommand]
        private async Task PrintInvoice()
        {
            if (CartItems == null || !CartItems.Any())
            {
                await Shell.Current.DisplayAlert("Error", "Cart is empty", "OK");
                return;
            }

            try
            {
                await _printService.HandleInvoice(CartItems.ToList(), TotalAmount, false);
                await Toast.Make("Invoice sent to printer").Show();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Failed to print: {ex.Message}", "OK");
            }
        }
    }
}
