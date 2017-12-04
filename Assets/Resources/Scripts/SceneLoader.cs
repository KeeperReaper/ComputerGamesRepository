using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

    public Text gameover;
	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().name.Contains("Gameover"))
        {
            gameover.text = (ScoreManager.player1Score > ScoreManager.player2Score) ? "Player 1 Won" : "Player 2 Won";
            ScoreManager.player1Score = 0;
            ScoreManager.player2Score = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Contains("Level"))
        {
            if (sceneName.Contains("1"))
            {
                if (ScoreManager.player1Score == 10 || ScoreManager.player2Score == 10)
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (sceneName.Contains("2"))
            {
                if (ScoreManager.player1Score == 20 || ScoreManager.player2Score == 20)
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (sceneName.Contains("3"))
            {
                if (ScoreManager.player1Score > 30 || ScoreManager.player2Score > 30)
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
    public void loadSpecificScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void exit() {
        EditorApplication.isPlaying = false;
    }
}
