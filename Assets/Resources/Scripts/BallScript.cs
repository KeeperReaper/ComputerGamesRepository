using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
   
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(0, 1) == 1 ? 150f : -150f, Random.Range(0, 1) == 1 ? 500f : -500f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<Rigidbody2D>().velocity.x.ToString().Contains("-")) // On each collision it increases velocity respectively on where the ball is going next
            GetComponent<Rigidbody2D>().velocity = new Vector2((GetComponent<Rigidbody2D>().velocity.x) - 30f, GetComponent<Rigidbody2D>().velocity.y);
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2((GetComponent<Rigidbody2D>().velocity.x) + 30f, GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(0, 1) == 1 ? 150f : -150f, Random.Range(0, 1) == 1 ? 500f : -500f);
        transform.position = new Vector3(500, 300, 0); // Goes back in the middle.
        string sceneName = SceneManager.GetActiveScene().name;

        if (collision.gameObject.name.Equals("Player1Goal"))
            ScoreManager.player2Score += (int.Parse(sceneName.Substring(sceneName.Length - 1)));
        else if (collision.gameObject.name.Equals("Player2Goal"))
            ScoreManager.player1Score += (int.Parse(sceneName.Substring(sceneName.Length - 1)));

        if (ScoreManager.player1Score == 10 || ScoreManager.player2Score == 10 || ScoreManager.player1Score == 30 || ScoreManager.player2Score == 30)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
