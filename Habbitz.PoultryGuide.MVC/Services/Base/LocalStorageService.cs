using Habbitz.PoultryGuide.MVC.Contracts;
using Hanssens.Net;
using System.Collections.Generic;

namespace Habbitz.PoultryGuide.MVC.Services.Base
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storage;
        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "Habbitz.PoultryGuide"
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

        public bool Exists(string key)
        {
            return _storage.Exists(key);
        }

        public T GetStorageValue<T>(string key)
        {
            return _storage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}
