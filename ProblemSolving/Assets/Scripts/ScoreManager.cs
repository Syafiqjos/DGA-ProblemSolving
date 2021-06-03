using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public const int gameScoreDelta = 100;
    public static int gameScore = 0;

    void Awake()
    {
        Instance = this;
        gameScore = 0;
    }

    private void Start()
    {

    }

    public static void AddScore()
    {
        gameScore += gameScoreDelta;
    }
}
