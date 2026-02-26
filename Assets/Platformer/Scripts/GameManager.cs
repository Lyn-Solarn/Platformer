using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void GameOver();
    public static event GameOver OnGameOver;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GoalBehavior.OnPlayerWon += OnPlayerWon;
        TimeController.OnTimeRanOut += OnTimeRanOut;
        GoombaBehavior.OnPlayerDied += OnPlayerDied;
    }

    void OnDestroy()
    {
        GoalBehavior.OnPlayerWon -= OnPlayerWon;
        TimeController.OnTimeRanOut -= OnTimeRanOut;
        GoombaBehavior.OnPlayerDied -= OnPlayerDied;
    }

    void OnPlayerDied()
    { 
        Debug.Log("The Goomba Killed Mario! You Lose!"); 
        OnGameOver?.Invoke();
    }

    void OnTimeRanOut()
    {
        Debug.Log("Time Ran Out! You Lose!");
        OnGameOver?.Invoke();
    }

    void OnPlayerWon()
    {
        Debug.Log("Mario Reached the Goal! You Win!");
        OnGameOver?.Invoke();
    }
}
