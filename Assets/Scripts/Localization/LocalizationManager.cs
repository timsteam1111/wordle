using UnityEngine;

namespace Localization
{
    public class LocalizationManager : MonoBehaviour
    {
        public static LocalizationManager Instance;
        public LocalizationData currentLocalization;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            currentLocalization.Initialize();
        }

        public string Get(string key)
        {
            return currentLocalization.Get(key);
        }

        public void SetLanguage(LocalizationData newLocalization)
        {

            currentLocalization = newLocalization;
            currentLocalization.Initialize();

            // Можно вызвать обновление UI:
            LocalizationText[] allTexts = FindObjectsOfType<LocalizationText>();
            foreach (var t in allTexts)
                t.UpdateText();
        }
    }
}