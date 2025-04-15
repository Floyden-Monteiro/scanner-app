using scannermaui.Services.Interfaces;

namespace ScannerApp.Tests.Mocks
{
    public class MockStorageService : IStorageService
    {
        private readonly Dictionary<string, string> _storage = new();

        public string Get(string key, string defaultValue)
        {
            return _storage.TryGetValue(key, out var value) ? value : defaultValue;
        }

        public void Set(string key, string value)
        {
            _storage[key] = value;
        }

        public void Clear()
        {
            _storage.Clear();
        }
    }
}