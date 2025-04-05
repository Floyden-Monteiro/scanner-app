namespace scannermaui.Services.interfaces
{
    public interface IAuthService
    {
        Task<bool> Login(string username, string password);
        Task Logout();
    }
}