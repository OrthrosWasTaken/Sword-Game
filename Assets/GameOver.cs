using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameOverScreen gameOverScreen;  // Assign in Inspector
    public PlayerHealth playerHealth; // Reference to the player's health script
    public int playerScore;

    private bool isGameOver = false;

     public void PlayerDied()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOverScreen.setup(0);
            Time.timeScale = 0f; 
            Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true;
        }
    }
}