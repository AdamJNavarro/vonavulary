using Hanssens.Net;
using Vonavulary.UI.Contracts;

namespace Vonavulary.UI.Services;

public class LocalStorageService : ILocalStorageService
{
    private readonly LocalStorage _storage;

    public LocalStorageService()
    {
        var config = new LocalStorageConfiguration()
        {
            AutoLoad = true,
            AutoSave = true,
            Filename = "Vonavulary.LS",
        };
        _storage = new LocalStorage(config);
    }

    public void ClearStorage(List<string> keys)
    {
        foreach (var key in keys)
        {
            _storage.Remove(key);
        }
    }

    public void SetStorageValue<T>(string key, T value)
    {
        _storage.Store(key, value);
        _storage.Persist();
    }

    public T GetStorageValue<T>(string key)
    {
        return _storage.Get<T>(key);
    }

    public bool Exists(string key)
    {
        return _storage.Exists(key);
    }
}
