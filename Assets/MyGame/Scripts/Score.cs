using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI pointsScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggereventPlayer" + collision.gameObject.name);

        if (collision.gameObject.name == "FlowerPickup(Clone)")
        {
            score += 5;
            Debug.Log("score " + score);
            pointsScore.text = score.ToString();
        }

        if (collision.gameObject.name == "BombPickup(Clone)")
        {
            score -= 10;
            Debug.Log("score " + score);
            pointsScore.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }
}
