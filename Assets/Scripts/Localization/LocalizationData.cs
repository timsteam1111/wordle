using System.Collections.Generic;
using UnityEngine;

namespace Localization
{
    [System.Serializable]
    public class LocalizationEntry
    {
        public string key;
        public string value;
    }
    
    [CreateAssetMenu(fileName = "Localization", menuName = "Localization/Language Data")]
    public class LocalizationData : ScriptableObject
    {
        public string languageCode; // например: "en", "ru"
        public List<LocalizationEntry> entries;

        private Dictionary<string, string> _dictionary;

        public void Initialize()
        {
            _dictionary = new Dictionary<string, string>();
            foreach (var entry in entries)
            {
                _dictionary[entry.key] = entry.value;
            }
        }

        public string Get(string key)
        {
            if (_dictionary == null) Initialize();
            return _dictionary.ContainsKey(key) ? _dictionary[key] : $"[{key}]";
        }
    }
}