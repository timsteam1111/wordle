using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject screenMainMenu;
    [SerializeField] private GameObject screenSetting;
    
    private void Start()
    {
        screenSetting.SetActive(false);
        screenMainMenu.SetActive(true);
    }
    
    public void OnButtonStartClick()
    {
        mushroom.SetActive(false);
        buttonStart.SetActive(false);
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
}