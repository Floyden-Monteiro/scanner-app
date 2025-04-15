using System.Collections.ObjectModel;
using System.ComponentModel;
using scannermaui.Models;

namespace scannermaui.Services.interfaces
{
    public interface ICartService
    {
        int TotalQuantity { get; }
        decimal TotalAmount { get; }
        event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<CartItem> GetCartItems();
        void AddToCart(CartItem item);
        void RemoveFromCart(CartItem item);
        void SaveCartItems();
    }
}
