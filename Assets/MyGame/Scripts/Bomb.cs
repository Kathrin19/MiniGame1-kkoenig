using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private string player = "Player";
    private string bottomCollider = "BottomCollider";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == bottomCollider)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == player)
        {
            Destroy(gameObject);
        }
    }
}
