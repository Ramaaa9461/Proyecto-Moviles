using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    string sceneMenu = "Menu";
    string sceneSinglePlayer = "GamplaySinglePlayer";
    string sceneMultiplayer = "GamplayMultiplayer";
    string sceneCredits = "Credits";
    string sceneTransition = "Transition";
    string sceneEndScreen = "EndScreen";


    private void Awake()
    {
            DontDestroyOnLoad(gameObject);
    }



    public void goToSinglePlayerGameplay()
    {
        //  SceneManager.LoadScene("GamplaySinglePlayer");
        StartCoroutine(sceneLoader(sceneSinglePlayer, 1.5f));
    }

    public void goToTwoPlayerGameplay()
    {
        //SceneManager.LoadScene("GamplayMultiplayer");
        StartCoroutine(sceneLoader(sceneMultiplayer, 1.5f));

    }

    public void goToCredis()
    {
        // SceneManager.LoadScene("Credits");
        StartCoroutine(sceneLoader(sceneCredits, 0.25f));

    }

    public void goToMenu()
    {
        //     SceneManager.LoadScene("Menu");
        StartCoroutine(sceneLoader(sceneMenu, 0.5f));

    }
    public void goToEndScreen()
    {
        //     SceneManager.LoadScene("Menu");
        StartCoroutine(sceneLoader(sceneEndScreen, 0.2f));

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

    IEnumerator sceneLoader(string sceneName, float seconsWait)
    {


        SceneManager.LoadScene(sceneTransition); //Escena de transicion


        yield return null;


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;


        while (asyncLoad.progress < 0.9f)
        {
            Debug.Log("Carga: " + asyncLoad.progress);
            yield return null;
        }

        yield return new WaitForSeconds(seconsWait);

        asyncLoad.allowSceneActivation = true;

        // Destroy(gameObject);
    }

}
