using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOversScript : MonoBehaviour
{

    public Text GameOverText;
	void Start ()
    {
        GameOverText.text = "Game Over - Score: " + References.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
