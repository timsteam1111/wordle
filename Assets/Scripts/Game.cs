using Localization;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject screenMainMenu;
    [SerializeField] private GameObject screenSetting;
    [SerializeField] private GameObject field;
    [SerializeField] private GameObject backgroundField;
    [SerializeField] private GameObject firstLevelButton;
    [SerializeField] private GameObject firstPlayingField;
    [SerializeField] private GameObject secoundPlayingField;
    [SerializeField] private GameObject thirdPlayingField;
    [SerializeField] private GameObject buttonBack;
    
    [Space]
    [SerializeField] private LocalizationData ru;
    [SerializeField] private LocalizationData en;

    private bool _isEnglish = true;
    
    private void Start()
    {
        screenSetting.SetActive(false);
        screenMainMenu.SetActive(true);
        field.SetActive(false);
        backgroundField.SetActive(false);
        firstPlayingField.SetActive(false);
    }
    
    public void OnButtonStartClick()
    {
        mushroom.SetActive(false);
        buttonStart.SetActive(false);
        field.SetActive(true);
        backgroundField.SetActive(true);
        firstLevelButton.SetActive(true);
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
        firstLevelButton.SetActive(field);
        screenMainMenu.SetActive(false);
        screenSetting.SetActive(false);
        backgroundField.SetActive(true);
        secoundPlayingField.SetActive(true);
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