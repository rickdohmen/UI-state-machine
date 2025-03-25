// Purpose: This script is used to control the main menu of the game. It is used to start the game, open the settings menu, and quit the game.
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public void OnClickStart()
    {
        
    }
    public void OnClickSettings()
    {
       MenuController.LoadMenu(Menu.SETTINGS, gameObject);
    }

    public void OnClickCredits()
    {
        MenuController.LoadMenu(Menu.CREDITS, gameObject);
    }
}
