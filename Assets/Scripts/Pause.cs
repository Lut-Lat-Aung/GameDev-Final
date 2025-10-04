using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [Header("UI References")]
    public GameObject pausePanel;   // assign your panel in Inspector

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    // Pause the game
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f; // freeze game time
        isPaused = true;
    }

    // Resume the game
    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f; // resume game time
        isPaused = false;
    }

    // Restart current scene
    public void RestartGame()
    {
        Time.timeScale = 1f; // reset time scale before reloading
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Go back to Main Menu
    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // make sure "MainMenu" is in Build Settings
    }
}
