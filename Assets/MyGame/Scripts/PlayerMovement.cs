using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 6.0f;
    private float leftBoundary = -5.6f;
    private float rightBoundary = 5.7f;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, leftBoundary , rightBoundary);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    void Update()
    {
        Move();
    }
}
