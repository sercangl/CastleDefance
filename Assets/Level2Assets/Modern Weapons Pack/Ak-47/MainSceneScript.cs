using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Again()
    {
        SceneManager.LoadScene(3);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
