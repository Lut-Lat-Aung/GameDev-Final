using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigate : MonoBehaviour
{
    // Load Flying scene
    public void PlayFlying()
    {
        SceneManager.LoadScene("Flying");
    }

    // Load Driving scene
    public void PlayDriving()
    {
        SceneManager.LoadScene("Driving");
    }

    // Load Sumo scene
    public void PlaySumo()
    {
        SceneManager.LoadScene("Sumo");
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Game is exiting..."); // works in editor
        Application.Quit(); // works in build
    }
}
