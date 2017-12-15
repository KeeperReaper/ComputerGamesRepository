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
            gameover.text = (ScoreManager.totalplayer1Score > ScoreManager.totalplayer2Score) ? "Player 1 Won" :
                (ScoreManager.totalplayer1Score < ScoreManager.totalplayer2Score) ? "Player 2 Won" : "Draw";
            ScoreManager.resetScore();
        }
    }
	
	// Update is called once per frame
	void Update () {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Contains("Level"))
        {
            if (sceneName.Contains("1"))
            {
                if (ScoreManager.player1Score >= 10 || ScoreManager.player2Score >= 10)
                {
                    ScoreManager.appendTotal();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            else if (sceneName.Contains("2"))
            {
                if (ScoreManager.player1Score >= 20 || ScoreManager.player2Score >= 20)
                {
                    ScoreManager.appendTotal();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            else if (sceneName.Contains("3"))
            {
                if (ScoreManager.player1Score >= 30 || ScoreManager.player2Score >= 30)
                {

                    ScoreManager.appendTotal();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
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
