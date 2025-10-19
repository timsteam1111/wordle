using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Word : MonoBehaviour
    {
        [SerializeField] private List<Letter> letters;
        
        private int _indexCurrentLetter;

        private void Awake()
        {
            _indexCurrentLetter = 0;
        }

        public void AddLetter(char letter)
        {
            Letter currentLetter = letters[_indexCurrentLetter];
            if (currentLetter.IsExistsLetter())
                return;
            
            currentLetter.SetLetter(letter);
            
            if (_indexCurrentLetter == letters.Count - 1)
            {
                return;
            }
            _indexCurrentLetter++;
        }
    }
}