using System.Net.Http.Json;
using scannermaui.Models;
using scannermaui.Services.interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;

namespace scannermaui.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        // private const string BaseUrl = "http://10.197.201.137:5254";
        private const string BaseUrl = "http://10.0.2.2:5254";

        private readonly Cloudinary _cloudinary;

        public ApiService(IConfiguration configuration)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };

            var cloudinarySettings = new CloudinarySettings
            {
                CloudName = "Cloud-Name",
                ApiKey = "API-KEY",
                ApiSecret = "API-SECRET"

            };

            var account = new Account(
                cloudinarySettings.CloudName,
                cloudinarySettings.ApiKey,
                cloudinarySettings.ApiSecret);

            _cloudinary = new Cloudinary(account);
        }

        public async Task<LoginResponse> LoginAsync(string username, string password)
        {
            var loginRequest = new LoginRequest
            {
                UserName = username,
                Password = password
            };

            var response = await _httpClient.PostAsJsonAsync("/auth/login", loginRequest);
            return response.IsSuccessStatusCode ?
                await response.Content.ReadFromJsonAsync<LoginResponse>() : null;
        }

        public async Task<ProductResponse> ScanProductAsync(string barcode)
        {
            try
            {
                var token = await SecureStorage.GetAsync("UserToken");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var request = new ProductRequest { Barcode = barcode };
                var response = await _httpClient.PostAsJsonAsync("/product/scan", request);

                return await response.Content.ReadFromJsonAsync<ProductResponse>();
            }
            catch (Exception)
            {
                return new ProductResponse
                {
                    StatusCode = 404,
                    Message = "Product not found"
                };
            }
        }

        public async Task<ProductListResponse> GetProductsAsync()
        {
            try
            {
                var token = await SecureStorage.GetAsync("UserToken");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync("/product");
                return await response.Content.ReadFromJsonAsync<ProductListResponse>();
            }
            catch (Exception)
            {
                return new ProductListResponse
                {
                    StatusCode = 500,
                    Message = "Failed to load products"
                };
            }
        }

        public async Task<ApiResponse<Product>> AddProductAsync(Product product)
        {
            try
            {
                var token = await SecureStorage.GetAsync("UserToken");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.PostAsJsonAsync("/product/add", product);
                return await response.Content.ReadFromJsonAsync<ApiResponse<Product>>();
            }
            catch (Exception)
            {
                return new ApiResponse<Product>
                {
                    StatusCode = 500,
                    Message = "Failed to add product"
                };
            }
        }

        public async Task<ApiResponse<Product>> UpdateProductAsync(string barcode, Product product)
        {
            try
            {
                var token = await SecureStorage.GetAsync("UserToken");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.PutAsJsonAsync($"/product/update/{barcode}", product);
                return await response.Content.ReadFromJsonAsync<ApiResponse<Product>>();
            }
            catch (Exception)
            {
                return new ApiResponse<Product>
                {
                    StatusCode = 500,
                    Message = "Failed to update product"
                };
            }
        }

        public async Task<ApiResponse<Product>> DeleteProductAsync(string barcode)
        {
            try
            {
                var token = await SecureStorage.GetAsync("UserToken");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.DeleteAsync($"/product/delete/{barcode}");
                return await response.Content.ReadFromJsonAsync<ApiResponse<Product>>();
            }
            catch (Exception)
            {
                return new ApiResponse<Product>
                {
                    StatusCode = 500,
                    Message = "Failed to delete product"
                };
            }
        }

        public async Task<string> UploadImageToCloudinary(Stream imageStream, string fileName)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(fileName, imageStream),
                Transformation = new Transformation()
                    .Width(500)
                    .Height(500)
                    .Crop("fill")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return uploadResult.SecureUrl.ToString();
        }
    }
}