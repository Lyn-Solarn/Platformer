using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    public delegate void PlayerWon();
    public static event PlayerWon OnPlayerWon;
    
    void Start()
    {
        GameManager.OnGameOver += GameOver;
    }
    
    void OnTriggerEnter(Collider other)
    {
        OnPlayerWon?.Invoke();
    }

    void GameOver()
    {
        Destroy(gameObject);
    }
}
