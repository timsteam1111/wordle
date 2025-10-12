using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonSettings;
    [SerializeField] private GameObject buttonLanguedge;
    [SerializeField] private GameObject settingsScreen;
    [SerializeField] private GameObject buttonBackFromSettings;
    
    private void Start()
    {
        buttonLanguedge.SetActive(false);
        settingsScreen.SetActive(false);
        buttonBackFromSettings.SetActive(false);
    }
    
    public void OnButtonStartClick()
    {
        mushroom.SetActive(false);
        buttonStart.SetActive(false);
    }
    
    public void OnSettingsClick()
    {
        mushroom.SetActive(false);
        buttonStart.SetActive(false);
        buttonBackFromSettings.SetActive(true);
        buttonSettings.SetActive(false);
        settingsScreen.SetActive(true);
        buttonLanguedge.SetActive(true);
    }
    
    public void GoBackFromSettings()
    {
        mushroom.SetActive(true);
        buttonStart.SetActive(true);
        buttonBackFromSettings.SetActive(false);
        buttonSettings.SetActive(true);
        settingsScreen.SetActive(false);
        buttonLanguedge.SetActive(false);
    }
}