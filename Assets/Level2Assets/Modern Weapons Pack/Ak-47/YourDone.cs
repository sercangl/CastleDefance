using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class YourDone : MonoBehaviour {


    public Text YourDoneText;
	// Use this for initialization
	void Start () {
        YourDoneText.text = "Your Done - Score: " + References.score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
