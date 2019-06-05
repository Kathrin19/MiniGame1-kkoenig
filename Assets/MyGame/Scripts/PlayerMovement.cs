﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 6.0f;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, -5.6f, 5.6f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    void Update()
    {
        Move();
    }
}
