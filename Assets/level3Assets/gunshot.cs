using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
    }


}
