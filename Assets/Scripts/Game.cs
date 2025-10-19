using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Keyboard;
using Localization;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject screenMainMenu;
    [SerializeField] private GameObject screenSetting;
    [SerializeField] private GameObject field;
    [SerializeField] private GameObject backgroundField;
    [SerializeField] private GameObject firstLevelButton;
    [SerializeField] private GameObject secoundLevelButton;
    [SerializeField] private GameObject thirdLevelButton;
    [SerializeField] private GameObject firstPlayingField;
    [SerializeField] private GameObject buttonBack;
    [SerializeField] private GameObject firstWord;
    [SerializeField] private GameObject secoundWord;
    [SerializeField] private GameObject thirdWord;
    [SerializeField] private GameObject fourthWord;
    [SerializeField] private GameObject fifthWord;
    [SerializeField] private GameObject sixthWord;
    
    [Space]
    [SerializeField] private LocalizationData ru;
    [SerializeField] private LocalizationData en;

    [Space] 
    [SerializeField] private List<KeyboardCharButton> letters;

    [Space]
    [SerializeField] private List<Word> words;

    private bool _isEnglish = true;

    private void Awake()
    {
        foreach (var word in words)
        {
            word.gameObject.SetActive(false);
        }
        
    }

    private void Start()
    {
        screenSetting.SetActive(false);
        screenMainMenu.SetActive(true);
        field.SetActive(false);
        backgroundField.SetActive(false);
        firstPlayingField.SetActive(false);
        firstLevelButton.SetActive(false);
        secoundLevelButton.SetActive(false);
        thirdLevelButton.SetActive(false);
        
        

        foreach (var letter in letters)
        {
            letter.Pressed += OnLetterPressed;
        }
    }

    public IEnumerable Word { get; set; }

    private void OnLetterPressed(char symbol)
    {
        Debug.Log(symbol);
    }
    
    public void OnButtonStartClick()
    {
        mushroom.SetActive(false);
        buttonStart.SetActive(false);
        field.SetActive(true);
        backgroundField.SetActive(true);
        firstLevelButton.SetActive(true);
        secoundLevelButton.SetActive(true);
        thirdLevelButton.SetActive(true);
    }
    
    public void OnSettingsClick()
    {
        screenSetting.SetActive(true);
        screenMainMenu.SetActive(false);
    }
    
    public void GoBackFromSettings()
    {
        screenSetting.SetActive(false);
        screenMainMenu.SetActive(true);
    }

    public void OnLanguageClick()
    {
        _isEnglish = !_isEnglish;
        LocalizationManager.Instance.SetLanguage(_isEnglish ? en : ru);
    }

    public void OnFirstLevelButtonClick()
    {
        field.SetActive(false);
        firstLevelButton.SetActive(false);
        secoundLevelButton.SetActive(false);
        thirdLevelButton.SetActive(false);
        screenMainMenu.SetActive(false);
        screenSetting.SetActive(false);
        backgroundField.SetActive(true);

        List<string> wordsString = new List<string>();
        wordsString.Add("Книга");
        wordsString.Add("Ручка");
        wordsString.Add("Батон");
        int index = Random.Range(0, wordsString.Count);
        string word = wordsString[index];
        
        
        foreach (var word1 in words)
        {
            word1.gameObject.SetActive(true);
        }
        
    }
    public void ButtonForMe()
    {
        field.SetActive(false);
        firstLevelButton.SetActive(false);
        screenMainMenu.SetActive(true);
        screenSetting.SetActive(false);
        backgroundField.SetActive(false);
        firstPlayingField.SetActive(false); 
        mushroom.SetActive(true);
        buttonStart.SetActive(true);

    
    }
    
    
    
}