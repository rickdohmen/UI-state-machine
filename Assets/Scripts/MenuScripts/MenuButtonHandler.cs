using UnityEngine;

public class MenuButtonHandler : MonoBehaviour
{
    public void OpenMainMenu()
    {
        MenuStateManager.ChangeState(Menu.MAIN_MENU);
    }

    public void OpenSettingsMenu()
    {
        MenuStateManager.ChangeState(Menu.SETTINGS);
    }

    public void OpenCreditsMenu()
    {
        MenuStateManager.ChangeState(Menu.CREDITS);
    }
}
