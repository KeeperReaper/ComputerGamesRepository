using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int player1Score = 0, player2Score = 0;
    public Text player1Scoreboard, player2Scoreboard, gameover;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (SceneManager.GetActiveScene().name.Contains("Level"))
        {
            player1Scoreboard.text = "" + player1Score;
            player2Scoreboard.text = "" + player2Score;

        }
        else if (SceneManager.GetActiveScene().name.Contains("Gameover")) {
            gameover.text = player1Score > player2Score ? "Player 1 Won" : "Player 2 Won";
        }
    }
    
}

