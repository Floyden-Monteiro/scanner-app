namespace scannermaui.Services.interfaces
{
    public interface IAuthService
    {
        Task<string?> Login(string username, string password);
        Task Logout();
    }
}