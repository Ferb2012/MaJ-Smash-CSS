﻿using UnityEngine;
using System.Collections;

public class CursorMovement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, y, 0) * Time.deltaTime * speed;

        Vector3 worldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        transform.position = new Vector3(
          Mathf.Clamp(transform.position.x, -worldSize.x, worldSize.x),
          Mathf.Clamp(transform.position.y, -worldSize.y, worldSize.y),
          transform.position.z
        );
    }
}
