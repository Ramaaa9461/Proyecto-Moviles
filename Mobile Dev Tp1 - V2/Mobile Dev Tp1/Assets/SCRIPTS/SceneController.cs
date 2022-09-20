using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void goToSinglePlayerGameplay()
    {
        SceneManager.LoadScene("GamplaySinglePlayer");
    }

    public void goToTwoPlayerGameplay()
    {
        SceneManager.LoadScene("GamplayMultiplayer");

    }

    public void goToCredis()
    {
        SceneManager.LoadScene("Credits");

    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
