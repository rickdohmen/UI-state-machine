using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits() => SceneManager.LoadScene("Credits");

    public void Settings() => SceneManager.LoadScene("Settings");

    public void QuitGame() => Application.Quit();
}
