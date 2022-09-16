using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public enum  Difficulty_Type { EASY , MEDIUM, HARD  };
    private Difficulty_Type difficulty_Type;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetDifficulty(Difficulty_Type difficulty)
    {

        difficulty_Type = difficulty;

    }

}
