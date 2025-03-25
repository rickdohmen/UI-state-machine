using UnityEngine;

public static class MenuController
{
    public static bool isInitialized { get; private set; }
    public static GameObject mainMenu, settingsMenu, creditsMenu;
    
    public static void Initialize()
    {
        if (isInitialized) return;
        mainMenu = GameObject.Find("MainMenu");
        settingsMenu = GameObject.Find("SettingsMenu");
        creditsMenu = GameObject.Find("CreditsMenu");
        isInitialized = true;
    }
    
    public static void LoadMenu(Menu menu, GameObject callingMenu)
    {
        if (!isInitialized) Initialize();
        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                settingsMenu.SetActive(false);
                creditsMenu.SetActive(false);
                break;
            case Menu.SETTINGS:
                mainMenu.SetActive(false);
                settingsMenu.SetActive(true);
                creditsMenu.SetActive(false);
                break;
            case Menu.CREDITS:
                mainMenu.SetActive(false);
                settingsMenu.SetActive(false);
                creditsMenu.SetActive(true);
                break;
        }
    }
}
