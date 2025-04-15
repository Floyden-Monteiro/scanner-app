using Xunit;
using Moq;
using System.Net.Http;
using scannermaui.Models;
using scannermaui.Services;
using scannermaui.Services.interfaces;

namespace ScannerApp.Tests.Services
{
    public class ApiServiceTests
    {
        private readonly Mock<IApiService> _mockApiService;

        public ApiServiceTests()
        {
            _mockApiService = new Mock<IApiService>();
        }

        [Fact]
        public async Task ScanProduct_ReturnsProduct()
        {

            var expectedResponse = new ProductResponse
            {
                StatusCode = 200,
                Data = new ProductData
                {
                    Barcode = "123456789",
                    Name = "Test Product"
                }
            };
            _mockApiService.Setup(x => x.ScanProductAsync("123456789"))
                          .ReturnsAsync(expectedResponse);


            var result = await _mockApiService.Object.ScanProductAsync("123456789");


            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Test Product", result.Data.Name);
        }

        [Fact]
        public async Task AddProduct_Success()
        {

            var product = new Product
            {
                Barcode = "123456789",
                Name = "Test Product",
                Price = 9.99m
            };
            var expectedResponse = new ApiResponse<Product>
            {
                StatusCode = 200,
                Data = product
            };
            _mockApiService.Setup(x => x.AddProductAsync(product))
                          .ReturnsAsync(expectedResponse);


            var result = await _mockApiService.Object.AddProductAsync(product);


            Assert.Equal(200, result.StatusCode);
            Assert.Equal(product.Name, result.Data.Name);
        }

        [Fact]
        public async Task GetProducts_ReturnsProductList()
        {
         
            var expectedResponse = new ProductListResponse
            {
                StatusCode = 200,
                Data = new List<Product> 
                {
                    new Product { Barcode = "123", Name = "Test Product 1" },
                    new Product { Barcode = "456", Name = "Test Product 2" }
                }
            };
            _mockApiService.Setup(x => x.GetProductsAsync())
                          .ReturnsAsync(expectedResponse);

     
            var result = await _mockApiService.Object.GetProductsAsync();

          
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(2, result.Data.Count); 
            Assert.Equal("Test Product 1", result.Data[0].Name);  
        }

        [Fact]
        public async Task UpdateProduct_Success()
        {
            var product = new Product
            {
                Barcode = "123456789",
                Name = "Updated Product",
                Price = 19.99m
            };
            var expectedResponse = new ApiResponse<Product>
            {
                StatusCode = 200,
                Data = product,
                Message = "Product updated successfully"
            };
            _mockApiService.Setup(x => x.UpdateProductAsync("123456789", product))
                          .ReturnsAsync(expectedResponse);

       
            var result = await _mockApiService.Object.UpdateProductAsync("123456789", product);

         
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Updated Product", result.Data.Name);
            Assert.Equal(19.99m, result.Data.Price);
        }

        [Fact]
        public async Task DeleteProduct_Success()
        {
          
            var expectedResponse = new ApiResponse<Product>
            {
                StatusCode = 200,
                Message = "Product deleted successfully"
            };
            _mockApiService.Setup(x => x.DeleteProductAsync("123456789"))
                          .ReturnsAsync(expectedResponse);

         
            var result = await _mockApiService.Object.DeleteProductAsync("123456789");

         
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Product deleted successfully", result.Message);
        }
    }
}