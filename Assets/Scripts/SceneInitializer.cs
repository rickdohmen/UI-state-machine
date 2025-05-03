using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    [SerializeField] private Menu defaultMenu = Menu.MAIN_MENU;
    private void Start()
    {
        MenuController.Initialize(defaultMenu);
        MenuStateManager.ChangeState(defaultMenu);
    }

}
