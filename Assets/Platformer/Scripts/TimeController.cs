using System;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private float timeLeft = 100f;
    private bool gameOver = false;
    public delegate void TimeRanOut();
    public static event TimeRanOut OnTimeRanOut;

    void Start()
    {
         GameManager.OnGameOver += GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                OnTimeRanOut?.Invoke();
            }
            timeText.text = $"Time\n{timeLeft.ToString("#")}";
        }
    }

    void GameOver()
    {
        gameOver = true;
    }
}
