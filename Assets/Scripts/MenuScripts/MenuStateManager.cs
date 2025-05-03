using UnityEngine;

public static class MenuStateManager
{
    private static Menu currentState;

    public static void ChangeState(Menu newState)
    {
        if(currentState == newState) return; 

        if(MenuController.IsMenuRegistered(currentState))
        {
            MenuController.GetMenu(currentState).SetActive(false);
            Debug.Log($"Exited state:  {currentState}");
        }

        if(MenuController.IsMenuRegistered(newState))
        {
            MenuController.GetMenu(newState).SetActive(true);
            Debug.Log($"Entered state: {newState}");
        }
        else
        {
            Debug.LogError($"Menu {newState} is not registered.");
        }
    }

    public static Menu GetCurrentState()
    {
        return currentState;
    }
}
