using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    GameObject paddle1, paddle2;
    // Use this for initialization
    void Start()
    {
        paddle1 = GameObject.Find("Player1Paddle");
        paddle2 = GameObject.Find("Player2Paddle");
        StartCoroutine(startBall(1));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator startBall(int playerNo)
    {
        transform.position = new Vector3(500, 300, 0);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        float currentYDifference;
        if (playerNo == 1)
        {
            currentYDifference = paddle1.transform.position.y - transform.position.y;
        }
        else {
            currentYDifference = paddle2.transform.position.y - transform.position.y;
        }
        yield return new WaitForSeconds(0.5f);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Rigidbody2D>().velocity = new Vector2(playerNo == 1 ? -500f : 500f, currentYDifference);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<Rigidbody2D>().velocity.x.ToString().Contains("-"))
            GetComponent<Rigidbody2D>().velocity = new Vector2((GetComponent<Rigidbody2D>().velocity.x) - 30f, GetComponent<Rigidbody2D>().velocity.y);
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2((GetComponent<Rigidbody2D>().velocity.x) + 30f, GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (collision.gameObject.name.Equals("Player1Goal"))
        {
            ScoreManager.player2Score += (int.Parse(sceneName.Substring(sceneName.Length - 1)));
            StartCoroutine(startBall(1));
        } else if (collision.gameObject.name.Equals("Player2Goal")) {
            ScoreManager.player1Score += (int.Parse(sceneName.Substring(sceneName.Length - 1)));
            StartCoroutine(startBall(2));
        }
    }
}
