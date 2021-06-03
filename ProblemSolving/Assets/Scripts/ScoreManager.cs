using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public const int gameScoreDelta = 100;
    public static int gameScore = 0;
    public static int gameHighScore = 0;

    void Awake()
    {
        Instance = this;
        gameScore = 0;

        LoadData();
    }

    public static void AddScore()
    {
        gameScore += gameScoreDelta;
        if (gameScore > gameHighScore)
        {
            gameHighScore = gameScore;
        }
    }

    public static void SaveData()
    {
        PlayerPrefs.SetInt("highscore", gameHighScore);
        PlayerPrefs.Save();
    }

    public static void LoadData()
    {
        gameHighScore = PlayerPrefs.GetInt("highscore");
    }
}
