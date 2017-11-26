using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour {

    Vector3 paddlePosition;
    // Use this for initialization
    void Start () {
        paddlePosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        paddlePosition.y = Mathf.Clamp(Input.mousePosition.y, 50f, 555f);
        transform.position = paddlePosition;
    }
}
