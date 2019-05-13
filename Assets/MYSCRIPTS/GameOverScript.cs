using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
	
    
	// Update is called once per frame
	void Update ()
    {
   
	if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        Debug.Log("Game Over! You are out of lives.");
        SceneManager.LoadScene(7);
    }
}
