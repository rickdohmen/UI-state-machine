using UnityEngine;

public class MenuButtonHandler : MonoBehaviour
{
    public void OpenMainMenu()
    {
        MenuController.LoadMenu(Menu.MAIN_MENU);
    }

    public void OpenSettingsMenu()
    {
        MenuController.LoadMenu(Menu.SETTINGS);
    }

    public void OpenCreditsMenu()
    {
        MenuController.LoadMenu(Menu.CREDITS);
    }
}
