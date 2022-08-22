using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Ball")
        {
            string wallName = transform.name;
            gameManager.Score(wallName);
            col.gameObject.GetComponent<BallControl>().RestartGame();
        }
    }
}