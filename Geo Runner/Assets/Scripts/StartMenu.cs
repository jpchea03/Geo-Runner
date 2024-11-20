// This script controls the start menu

using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Opens the MainScene
    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Quits the game
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
