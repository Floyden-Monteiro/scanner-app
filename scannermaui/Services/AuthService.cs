using scannermaui.Models;
using scannermaui.Services.interfaces;

namespace scannermaui.Services
{
    public class AuthService : IAuthService
    {
        private readonly IApiService _apiService;

        public AuthService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string?> Login(string username, string password)
        {
            try
            {
                var response = await _apiService.LoginAsync(username, password);
                return response?.Token;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");
                return null;
            }
        }

        public Task Logout()
        {
           
            return Task.CompletedTask;
        }
    }
}
