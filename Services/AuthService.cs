using Microsoft.Maui.Storage;
using scannermaui.Services.interfaces;
using System.Collections.Generic;
using System.Net.Http.Json;
using scannermaui.Models;

namespace scannermaui.Services
{
    public class AuthService : IAuthService
    {
        private readonly IApiService _apiService;

        public AuthService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<bool> Login(string username, string password)
        {
            try
            {
                var response = await _apiService.LoginAsync(username, password);
                if (response?.Token != null)
                {
                    await SecureStorage.SetAsync("UserToken", response.Token);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");
                return false;
            }
        }

        public async Task Logout()
        {
            SecureStorage.Default.Remove("UserToken");
        }
    }
}