using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {


    public int score = 0;
    public Text ScoreText;
	// Use this for initialization
	void Start () {
        ScoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        References.score = score;
	}
     public void increaseScore()
    {
        score += 10;
        ScoreText.text = score.ToString();

    }

}
