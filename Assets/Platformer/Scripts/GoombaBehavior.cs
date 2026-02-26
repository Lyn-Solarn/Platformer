using UnityEngine;

public class GoombaBehavior : MonoBehaviour
{
    public delegate void PlayerDied();
    public static event PlayerDied OnPlayerDied;

    void Start()
    {
        GameManager.OnGameOver += GameOver;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            OnPlayerDied?.Invoke();
        }
    }

    void GameOver()
    {
        Destroy(gameObject);
    }
}