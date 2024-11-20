// This script manages the pause menu

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused; // Bool representing pause state

    public GameObject pauseMenuUI; // Game object for the UI canvas

    // Update is called once per frame
    void Update()
    {
        // If escape is pressed...
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If game currently paused, resume
            if (gamePaused)
            {
                Resume();
            }
            else // Otherwise, pause
            {
                Pause();
            }
        }
    }

    // Method to resume game
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Disables pause menu UI element
        Time.timeScale = 1f; // Sets timescale to 1 frame
        gamePaused = false; // Sets pause state to false
    }

    // Method to pause game
    void Pause()
    {
        pauseMenuUI.SetActive(true); // Enables pause menu UI element
        Time.timeScale = 0f; // Freezes game
        gamePaused = true; // Set pause state to true
    }

    // Method to open start menu
    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        Resume(); // To remove pause state
        SceneManager.LoadScene("StartMenu");
    }

    // Method to exit game
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
