using scannermaui.Services.Interfaces;

namespace scannermaui.Services
{
    public class StorageService : IStorageService
    {
        public string Get(string key, string defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public void Set(string key, string value)
        {
            Preferences.Set(key, value);
        }
    }
}