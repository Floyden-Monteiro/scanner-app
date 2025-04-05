using CommunityToolkit.Mvvm.ComponentModel;

namespace scannermaui.Models
{
    public partial class CartItem : ObservableObject
    {
        [ObservableProperty]
         string productName;

        [ObservableProperty]
         int quantity;
         [ObservableProperty]
         decimal price;
    }
}