using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private float timeLeft = 500f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = $"Time\n{timeLeft.ToString("#")}";
    }
}
