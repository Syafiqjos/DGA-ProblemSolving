using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }

    public float timeLimit = 30;
    public static float currentTime { get { return Instance.timeLimit; } }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (timeLimit > 0) {
            timeLimit -= Time.deltaTime;
        } else
        {
            GameManager.GameOver();
        }
    }
}
