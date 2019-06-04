using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower2 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "BottomCollider")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
