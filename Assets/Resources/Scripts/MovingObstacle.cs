using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {

    Vector3 movingObstacle;
    string direction;
    // Use this for initialization
    void Start () {
        movingObstacle = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (movingObstacle.y == 555f)
            direction = "down";
        else if(movingObstacle.y == 50f)
            direction = "up";

        movingObstacle.y += direction == "up" ? 5f : -5f;
        movingObstacle.y = Mathf.Clamp(movingObstacle.y, 50f, 555f);
        transform.position = movingObstacle;
    }
}
