using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void OnClickBack()
    {
        gameObject.SetActive(false);
        MenuController.LoadMenu(Menu.MAIN_MENU, gameObject);
    }
}
