using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDificulty : MonoBehaviour
{
    Difficulty difficulty;

    [SerializeField] GameObject obstaclesEasy;
    [SerializeField] GameObject obstaclesMedium;
    [SerializeField] GameObject obstaclesHard;

    private void Awake()
    {
        difficulty = GameObject.Find("Difficulty").GetComponent<Difficulty>();  
    }
    void Start()
    {
        switch (difficulty.GetDifficulty())
        {
            case 0:

               obstaclesMedium.SetActive(false);
               obstaclesHard.SetActive(false);
                break;

            case 1:

               obstaclesHard.SetActive(false);
                break;
            
        }


    }

}
