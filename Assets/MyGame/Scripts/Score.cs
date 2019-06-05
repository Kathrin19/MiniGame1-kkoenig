using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI pointsScore;
    public MyScore scoreCount; 

    void Start ()
    {
        scoreCount.score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggereventPlayer" + collision.gameObject.name);

        if (collision.gameObject.name == "FlowerPickup(Clone)")
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == "Flower2Pickup(Clone)")
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == "Flower3Pickup(Clone)")
        {
            scoreCount.score += 5;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }

        if (collision.gameObject.name == "BombPickup(Clone)")
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
