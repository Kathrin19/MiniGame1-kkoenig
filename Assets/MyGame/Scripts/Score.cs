using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI pointsScore;
    public MyScore scoreCount;
    private string flowerPickup = "FlowerPickup(Clone)";
    private string flower2Pickup = "Flower2Pickup(Clone)";
    private string flower3Pickup = "Flower3Pickup(Clone)";
    private string bombPickup = "BombPickup(Clone)";

    void Start ()
    {
        scoreCount.score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggereventPlayer" + collision.gameObject.name);

        if (collision.gameObject.name == flowerPickup)
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == flower2Pickup)
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == flower3Pickup)
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == bombPickup)
        {
            scoreCount.score -= 10;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }
}
