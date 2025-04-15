namespace scannermaui.Services.Interfaces
{
    public interface IStorageService
    {
        string Get(string key, string defaultValue);
        void Set(string key, string value);
    }
}