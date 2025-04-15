using System.Threading.Tasks;
using Xunit;
using Moq;
using scannermaui.Services;
using scannermaui.Services.interfaces;
using scannermaui.Models;


namespace ScannerApp.Tests.Services
{
    public class AuthServiceTests
    {
        private readonly Mock<IApiService> _mockApi;
        private readonly AuthService _authService;

        public AuthServiceTests()
        {
            _mockApi = new Mock<IApiService>();
            _authService = new AuthService(_mockApi.Object);
        }

        [Fact]
        public async Task Login_Success()
        {
            _mockApi.Setup(s => s.LoginAsync("test", "123"))
                    .ReturnsAsync(new LoginResponse { Token = "abc123" });

            var result = await _authService.Login("test", "123");

            Assert.Equal("abc123", result);
        }

        [Fact]
        public async Task Login_Failure()
        {
            _mockApi.Setup(s => s.LoginAsync("test", "wrong"))
                    .ReturnsAsync(new LoginResponse { Token = null });

            var result = await _authService.Login("test", "wrong");

            Assert.Null(result);
        }

        [Fact]
        public async Task Logout_DoesNothing()
        {
            await _authService.Logout();
            Assert.True(true);
        }
    }
}