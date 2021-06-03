using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static bool IsGameOver { get; private set; } = false;

    private void Awake()
    {
        Instance = this;
        IsGameOver = false;
    }

    public static void GameOver()
    {
        IsGameOver = true;
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
