using UnityEngine;

public class MenuRegistration : MonoBehaviour
{
    [SerializeField] private Menu menuType;

    private void Awake()
    {
        MenuController.RegisterMenu(menuType, gameObject);
    }
}
