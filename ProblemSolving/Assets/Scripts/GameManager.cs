using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static bool IsGameOver { get; private set; } = false;

    public GameObject gameplayUI;
    public GameObject gameOverUI;

    private void Awake()
    {
        Instance = this;
        IsGameOver = false;
    }

    private void Update()
    {
        gameplayUI.SetActive(!IsGameOver);
        gameOverUI.SetActive(IsGameOver);
    }

    public static void GameOver()
    {
        if (!IsGameOver)
        {
            ScoreManager.SaveData();
            IsGameOver = true;
        }
    }

    public static void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }    
}
