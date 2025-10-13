using System;
using TMPro;
using UnityEngine;

namespace Localization
{
    public class LocalizationText : MonoBehaviour
    {
        public string key;

        void Start()
        {
            UpdateText();
        }

        private void OnEnable()
        {
            UpdateText();
        }

        public void UpdateText()
        {
            var textComponent = GetComponent<TMP_Text>(); // можно заменить на Text
            if (textComponent != null && LocalizationManager.Instance != null)
            {
                textComponent.text = LocalizationManager.Instance.Get(key);
            }
        }
    }
}