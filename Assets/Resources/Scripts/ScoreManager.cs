using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int player1Score = 0, player2Score = 0, totalplayer1Score, totalplayer2Score;
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
    }
    public static void appendTotal()
    {
        totalplayer1Score += player1Score;
        totalplayer2Score += player2Score;
        player1Score = player2Score = 0;
    }
    public static void resetScore()
    {
        player1Score = player2Score = totalplayer1Score = totalplayer2Score = 0;
    }

}

