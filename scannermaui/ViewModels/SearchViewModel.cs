using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using scannermaui.Models;
using scannermaui.Services.interfaces;
using scannermaui.Views;
using CommunityToolkit.Maui.Views;

namespace scannermaui.ViewModels
{
    public partial class SearchViewModel : ObservableObject
    {
        private readonly IApiService _apiService;
        private readonly ICartService _cartService;

        [ObservableProperty]
        private List<Product> _products;

        [ObservableProperty]
        private List<Product> _searchResults;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _searchText;

        [ObservableProperty]
        private bool _isInCart;


        public SearchViewModel(IApiService apiService, ICartService cartService)
        {
            _apiService = apiService;
            _cartService = cartService;
            LoadProducts();
        }



        [RelayCommand]
        public async Task LoadProducts()
        {
            try
            {
                IsBusy = true;
                var response = await _apiService.GetProductsAsync();
                if (response.StatusCode == 200)
                {
                    Products = response.Data;
                    SearchResults = Products;
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task AddToCart(Product product)
        {
            System.Diagnostics.Debug.WriteLine($"🌟🌟🌟 {product.ImageUrl}");
            var cartItem = new CartItem
            {
                ProductName = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Quantity = 1
            };

            _cartService.AddToCart(cartItem);
            var toast = Toast.Make($"{product.Name} added to cart", ToastDuration.Short);
            await toast.Show();
        }

        [RelayCommand]
        private async Task NavigateToDetails(Product product)
        {
            if (product == null)
                return;

            var parameters = new Dictionary<string, object>
            {
                { "Product", product }
            };

            await Shell.Current.GoToAsync($"ProductDetails", true, parameters);
        }

        [RelayCommand]
        private async Task ShowAddProduct()
        {
            try
            {
                var popup = new AddProductPopup();
                popup.BindingContext = new AddProductViewModel(_apiService, popup);
                var result = await Shell.Current.CurrentPage.ShowPopupAsync(popup);

                if (result is bool success && success)
                {
                    await LoadProducts();
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }

        [RelayCommand]
        private async Task EditProduct(Product product)
        {
            if (product == null) return;

            try
            {
                var popup = new AddProductPopup();
                var viewModel = new AddProductViewModel(_apiService, popup)
                {
                    Barcode = product.Barcode,
                    Name = product.Name,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    SelectedImage = product.ImageUrl != null ?
                        ImageSource.FromUri(new Uri(product.ImageUrl)) : null,
                    IsEditMode = true
                };

                popup.BindingContext = viewModel;

                if (await Shell.Current.CurrentPage.ShowPopupAsync(popup) is bool success && success)
                {
                    await LoadProducts();
                    await Toast.Make("Product updated successfully").Show();
                }
            }
            catch (Exception ex)
            {
                await Toast.Make($"Error: {ex.Message}").Show();
            }
        }

        [RelayCommand]
        public async Task DeleteProduct(Product product)
        {
            try
            {
                bool shouldDelete = await Shell.Current.DisplayAlert(
                    "Confirm Delete",
                    $"Are you sure you want to delete {product.Name}?",
                    "Yes", "No");

                if (!shouldDelete) return;

                IsBusy = true;
                var response = await _apiService.DeleteProductAsync(product.Barcode);

                if (response.StatusCode == 200)
                {
                    await LoadProducts();
                    await Shell.Current.DisplayAlert("Success", "Product deleted successfully", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Error", response.Message, "OK");
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }


        partial void OnSearchTextChanged(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                SearchResults = Products;
                return;
            }

            SearchResults = Products?
                .Where(p => p.Name.Contains(value, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        [RelayCommand]
        private void SortByName()
        {
            if (SearchResults != null)
            {
                SearchResults = new List<Product>(SearchResults.OrderBy(p => p.Name));
            }
        }

        [RelayCommand]
        private void SortByPriceLowToHigh()
        {
            if (SearchResults != null)
            {
                SearchResults = new List<Product>(SearchResults.OrderBy(p => p.Price));
            }
        }

        [RelayCommand]
        private void SortByPriceHighToLow()
        {
            if (SearchResults != null)
            {
                SearchResults = new List<Product>(SearchResults.OrderByDescending(p => p.Price));
            }
        }
    }
}