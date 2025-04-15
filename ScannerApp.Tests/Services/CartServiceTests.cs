using Xunit;
using scannermaui.Models;
using scannermaui.Services;
using ScannerApp.Tests.Mocks;

namespace ScannerApp.Tests.Services
{
    public class CartServiceTests : IDisposable
    {
        private readonly CartService _cartService;
        private readonly MockStorageService _mockStorage;

        public CartServiceTests()
        {
            _mockStorage = new MockStorageService();
            _cartService = new CartService(_mockStorage);
        }

        public void Dispose()
        {
            _mockStorage.Clear();
        }

        [Fact]
        public void AddToCart_NewItem_AddsToCartWithQuantityOne()
        {

            var newItem = new CartItem { ProductName = "Test Product", Price = 10.99m };

            _cartService.AddToCart(newItem);

 
            var cartItems = _cartService.GetCartItems();
            Assert.Single(cartItems);
            Assert.Equal("Test Product", cartItems[0].ProductName);
            Assert.Equal(1, cartItems[0].Quantity);
            Assert.Equal(10.99m, cartItems[0].Price);
        }

        [Fact]
        public void AddToCart_ExistingItem_IncreasesQuantity()
        {
         
            var item = new CartItem { ProductName = "Test Product", Price = 10.99m };

            
            _cartService.AddToCart(item);
            _cartService.AddToCart(item);

         
            var cartItems = _cartService.GetCartItems();
            Assert.Single(cartItems);
            Assert.Equal(2, cartItems[0].Quantity);
            Assert.Equal(21.98m, _cartService.TotalAmount);
        }

        [Fact]
        public void RemoveFromCart_ExistingItem_RemovesFromCart()
        {
            
            var item = new CartItem { ProductName = "Test Product", Price = 10.99m };
            _cartService.AddToCart(item);

        
            _cartService.RemoveFromCart(_cartService.GetCartItems()[0]);

           
            Assert.Empty(_cartService.GetCartItems());
            Assert.Equal(0m, _cartService.TotalAmount);
        }
    }
}