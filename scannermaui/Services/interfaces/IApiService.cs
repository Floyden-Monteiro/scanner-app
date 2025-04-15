using scannermaui.Models;

namespace scannermaui.Services.interfaces
{
    public interface IApiService
    {
        Task<LoginResponse> LoginAsync(string username, string password);
        Task<ProductResponse> ScanProductAsync(string barcode);
        Task<ProductListResponse> GetProductsAsync();
        Task<ApiResponse<Product>> AddProductAsync(Product product);
        Task<ApiResponse<Product>> UpdateProductAsync(string barcode, Product product);
        Task<ApiResponse<Product>> DeleteProductAsync(string barcode);
        Task<string> UploadImageToCloudinary(Stream imageStream, string fileName);
    }
}