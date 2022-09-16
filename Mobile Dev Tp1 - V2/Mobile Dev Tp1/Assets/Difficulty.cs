using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    int difficulty_Type;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetDifficultyEasy()
    {
        difficulty_Type = 0;
    }
    public void SetDifficultyMedium()
    {
        difficulty_Type = 1;
    }
    public void SetDifficultyHard()
    {
        difficulty_Type = 2;
    }

    public int GetDifficulty()
    {
        return difficulty_Type;
    }
}
