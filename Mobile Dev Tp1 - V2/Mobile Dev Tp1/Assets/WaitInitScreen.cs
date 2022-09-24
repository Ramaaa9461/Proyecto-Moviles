using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitInitScreen : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Await());
    }

    IEnumerator Await()
    {
        yield return new WaitForSeconds(3);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
