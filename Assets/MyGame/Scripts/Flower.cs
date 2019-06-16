using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {
    public string bottomCollider = "BottomCollider";
    public string player = "Player";

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

