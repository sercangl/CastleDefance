using UnityEngine;

public class Node : MonoBehaviour {

    public Color HoverColor;
    public Color NotEnoughGoldColor;
    public Vector3 positionOffset;
   // [Header("Optional")]
   public GameObject tower;
   
     

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

     void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;

        if(tower != null)
        {
            Debug.Log("Can not build it here");
            return;
        }

        buildManager.BuildTowerOn(this);

    }
     void OnMouseEnter()
    {
       // if (buildManager.GetTowerToBuild() == null)
         //   return;

        if (!buildManager.CanBuild)
            return;


        if (buildManager.HaveMoney)
        {
            rend.material.color = HoverColor;
        }

        else
        {
            rend.material.color = NotEnoughGoldColor;
        }
        
    }
     void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    
   
}
