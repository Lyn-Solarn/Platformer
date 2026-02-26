using TMPro;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int coins = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (coins <= 9)
        {
            coinsText.text = "x0" + coins.ToString();
        }
        else
        {
            coinsText.text = "x" + coins.ToString();
        }
    }

    public void addCoins()
    {
        coins++;
    }
}