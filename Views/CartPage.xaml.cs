using Microsoft.Maui.Controls;
using scannermaui.ViewModels;
using Microsoft.Maui.Storage;

namespace scannermaui.Views
{
    public partial class CartPage : ContentPage
    {
        public CartPage(CartViewModel cartViewModel)
        {
            InitializeComponent();
            BindingContext = cartViewModel;

        }
    }
}