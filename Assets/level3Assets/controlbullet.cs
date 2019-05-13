using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlbullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

        charactercontrol character= GameObject.FindGameObjectWithTag("Player").GetComponent<charactercontrol>();
        GetComponent<Rigidbody>().AddForce(character.getposition()*2000);


		
	}
	
	
}
