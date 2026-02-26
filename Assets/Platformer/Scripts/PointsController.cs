using TMPro;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int points = 0;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = $"Mario\n{points.ToString()}";
    }
    
    public void addPoints(int addPoints)
    {
        points += addPoints;
    }
}
