using Microsoft.Maui.Controls;
using scannermaui.ViewModels;

namespace scannermaui.Views
{
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage(ProductDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}