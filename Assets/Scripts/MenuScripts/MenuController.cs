using System.Collections.Generic;
using UnityEngine;

public static class MenuController
{

    private static Dictionary<Menu, GameObject> menuDictionary = new Dictionary<Menu, GameObject>();
    public static bool isInitialized { get; private set; }
    
    public static void RegisterMenu(Menu menu, GameObject menuObject)
    {
        if (menuDictionary.ContainsKey(menu))
        {
            Debug.LogWarning($"Menu {menu} is already registered. Overwriting.");
            menuDictionary[menu] = menuObject;
        }
        else
        {
            menuDictionary.Add(menu, menuObject);
        }
    }

    public static void Initialize()
    {
        if (isInitialized) return;
        
        foreach (var menu in menuDictionary)
        {
            if(menu.Value == null)
            {
                Debug.LogError($"Menu {menu.Key} is not assigned in the inspector. Please assign it.");
            }
        }
    }
    
    public static void LoadMenu(Menu menu)
    {
        if (!isInitialized) Initialize();
        foreach (var kvp in menuDictionary)
        {
            if (kvp.Key == menu)
            {
                kvp.Value.SetActive(true);
            }
            else
            {
                kvp.Value.SetActive(false);
            }
        }
        Debug.Log($"Loaded menu: {menu}");
    }
}
