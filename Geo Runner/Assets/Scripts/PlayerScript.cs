// This script controls the player behavior

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce; // Force that the player jumps
    public static int score; // Score achieved by player

    [SerializeField]
    bool isGrounded = false; // Determines if player is on ground for jumping
    bool isAlive = true; // Determines if player is alive

    Rigidbody2D rb; // Players rigidbody2D object
    public TextMeshProUGUI scoreTxt; // Score UI element

    // Initialize and track score, get rigid body component
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        StartCoroutine(IncrementScore());
    }

    // Update is called once per frame
    void Update()
    {
        // If space key is pressed...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If player is on ground...
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce); // Jump!
                isGrounded = false; // Player is no longer on ground
            }
        }
    }

    // Method to increment score by 1 each second the player is alive
    private System.Collections.IEnumerator IncrementScore()
    {
        // While the player is still alive
        while (isAlive)
        {
            yield return new WaitForSeconds(1f); // Wait for 1 second
            score += 1; // Increment score by 1
            scoreTxt.text = "SCORE: " + score.ToString(); // Update the score text
        }
    }

    // Controls player collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player touches ground...
        if (collision.gameObject.CompareTag("ground"))
        {
            // If player is not already grounded...
            if (!isGrounded)
            {
                isGrounded = true; // Ground player
            }
        }

        // If player touches spike...
        if (collision.gameObject.CompareTag("spike"))
        {
            // End game
            isAlive = false;
            SceneManager.LoadScene("GameOver");
        }
    }
}
