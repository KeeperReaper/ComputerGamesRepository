using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour
{

    Vector3 paddlePosition;
    // Use this for initialization
    void Start()
    {
        paddlePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            paddlePosition.y -= 10f;
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            paddlePosition.y += 10f;
        }
        paddlePosition.y = Mathf.Clamp(paddlePosition.y, 50f, 555f);
        transform.position = paddlePosition;
    }
}
