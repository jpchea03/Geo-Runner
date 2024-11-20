// This script controls the game over screen

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // UI Elements
    public TextMeshProUGUI scoreTxt;

    // Runs on scene start
    void Start()
    {
        DisplayScore();
    }

    // Method to display the players score
    void DisplayScore()
    {
        scoreTxt.text = "SCORE: " + PlayerScript.score.ToString();
    }

    // Opens the StartMenu scene
    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("StartMenu");
    }

    // Opens MainScene, used to play game
    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }
}
