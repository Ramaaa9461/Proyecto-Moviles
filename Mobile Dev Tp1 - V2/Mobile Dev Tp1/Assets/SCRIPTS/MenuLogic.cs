using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    SceneController sceneController;
    Difficulty difficulty;

    void Awake()
    {
        sceneController = GameObject.Find("Scene_Controller").GetComponent<SceneController>();
        difficulty = GameObject.Find("Difficulty").GetComponent<Difficulty>();
    }

    public void goToSinglePlayerGameplay()
    {
        sceneController.goToSinglePlayerGameplay();
    }

    public void goToTwoPlayerGameplay()
    {
        sceneController.goToTwoPlayerGameplay();
    }

    public void goToCredis()
    {
        sceneController.goToCredis();
    }

    public void goToMenu()
    {
        sceneController.goToMenu();
    }
    public void goToEndScreen()
    {
        sceneController.goToEndScreen();
    }

    public void PauseGame()
    {
        sceneController.PauseGame();
    }

    public void ResumeGame()
    {
        sceneController.ResumeGame();
    }

    public void Exit()
    {
        sceneController.Exit();
    }



    public void SetDifficultyEasy()
    {
        difficulty.SetDifficultyEasy();
    }
    public void SetDifficultyMedium()
    {
        difficulty.SetDifficultyMedium();
    }
    public void SetDifficultyHard()
    {
        difficulty.SetDifficultyHard();
    }

    public int GetDifficulty()
    {
        return difficulty.GetDifficulty();
    }

}
