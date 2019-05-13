using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystemCode : MonoBehaviour {

    public GameObject partical;
    Gun gun;

	// Use this for initialization
	void Start () {
        gun = GetComponent<Gun>();
	}
	


	// Update is called once per frame
	void Update () {
		
        if ( gun.firing == true)
        {
            partical.SetActive(true);

        }else
        {
            partical.SetActive(false);
        }



	}
}
