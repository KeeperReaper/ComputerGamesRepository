using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Contains("Level1"))
        {
            if (ScoreManager.player1Score == 10 || ScoreManager.player2Score == 10)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (sceneName.Contains("Level2"))
        {
            if (ScoreManager.player1Score == 30 || ScoreManager.player2Score == 30)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
