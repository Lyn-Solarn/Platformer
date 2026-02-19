using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public CoinsController coinsController;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Brick"))
                {
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.CompareTag("Question"))
                {
                    coinsController.addPoints();
                }
            }
        }
    }
}