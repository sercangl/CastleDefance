using UnityEngine.UI;
using UnityEngine;

public class LivesUI : MonoBehaviour {

    public Text livesText;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        livesText.text = "Lives: " + PlayerStats.Lives.ToString();
	}
}
