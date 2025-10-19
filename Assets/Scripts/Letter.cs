using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Letter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI label;
        
        public void SetLetter(char letter)
        {
            label.SetText(letter.ToString());
        }

        public bool IsExistsLetter()
        {
            return label.text.Length > 0;
        }
    }
}