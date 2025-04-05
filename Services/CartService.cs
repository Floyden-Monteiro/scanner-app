using System.Collections.ObjectModel;
using System.Text.Json;
using scannermaui.Models;
using scannermaui.Services.interfaces;
using Microsoft.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;

namespace scannermaui.Services
{
    public partial class CartService : ObservableObject, ICartService
    {
        private ObservableCollection<CartItem> _cartItems;

        [ObservableProperty]
        private int _totalQuantity;

        [ObservableProperty]
        private decimal _totalAmount;

        public CartService()
        {
            _cartItems = LoadCartItems();
            UpdateTotals();
        }

        public ObservableCollection<CartItem> GetCartItems() => _cartItems;

        public void AddToCart(CartItem newItem)
        {
            var existingItem = _cartItems.FirstOrDefault(i => i.ProductName == newItem.ProductName);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductName = newItem.ProductName,
                    Price = newItem.Price,
                    Quantity = 1
                });
            }
            SaveCartItems();
            UpdateTotals();
        }

        public void RemoveFromCart(CartItem item)
        {
            _cartItems.Remove(item);
            SaveCartItems();
            UpdateTotals();
        }

        public void SaveCartItems()
        {
            var json = JsonSerializer.Serialize(_cartItems);
            Preferences.Set("CartItems", json);
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            TotalQuantity = _cartItems.Sum(item => item.Quantity);
            TotalAmount = _cartItems.Sum(item => item.Price * item.Quantity);
        }

        private ObservableCollection<CartItem> LoadCartItems()
        {
            try
            {
                var json = Preferences.Get("CartItems", string.Empty);
                if (!string.IsNullOrEmpty(json))
                {
                    var items = JsonSerializer.Deserialize<ObservableCollection<CartItem>>(json);
                    return items ?? new ObservableCollection<CartItem>();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Load cart error: {ex.Message}");
            }

            return new ObservableCollection<CartItem>();
        }

        public bool IsInCart(string productName)
        {
            return _cartItems.Any(item => item.ProductName == productName);
        }
    }
}