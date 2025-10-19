namespace DefaultNamespace
{
    public class GameManager
    {
        private string _currentWord = "";
        private int _wordLength = 5;
        
        public void OnLetterSelect(char letter)
        {
            if (_currentWord.Length >= _wordLength)
                return;
            
            _currentWord += letter;
        }

        public void OnWordCheck()
        {
            if (_currentWord.Length < _wordLength)
                return;
            
            // если слова в словаре нет, то вывести предупреждение и сделать return
            
            // если слово в словаре есть, то оставить его на поле и подсветить буквы
        }

        public void OnLetterRemove()
        {
            if (_currentWord.Length == 0)
                return;
            
            _currentWord = _currentWord.Substring(0, _currentWord.Length - 1);
        }
    }
}