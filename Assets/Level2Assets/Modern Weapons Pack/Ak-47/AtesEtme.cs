using UnityEngine;
using System.Collections;

public class AtesEtme : MonoBehaviour
{

    public float mermi, sarjor, sarjorsayi, menzil, hasar1, hasar2;
    public bool ates;
    RaycastHit hit;
  //  public Camera fpsCam;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && mermi > 0)
        {
            ates = true;
            mermi--;
        }


    }
    void FixedUpdate()
    {
        if (ates)
        {
            ates = false;
            if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit,menzil))
            {
                if (hit.transform.tag == "Dusman")
                {
                    Debug.Log("Dusman Vuruldu");
                    Destroy(hit.transform.gameObject);

                }
            }
        }

    }
}