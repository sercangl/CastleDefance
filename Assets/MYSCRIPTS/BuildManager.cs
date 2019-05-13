using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
            return;
        }
        instance = this;
        
    }

    public GameObject StandardTowerPrefab;
    public GameObject UpgradedTowerPrefab;
   
    private TowerBluePrint TowerToBuild;

   public bool CanBuild { get { return TowerToBuild != null; } }
   public bool HaveMoney { get { return PlayerStats.Money >= TowerToBuild.cost; } }

    public void BuildTowerOn(Node node)
    {
        if(PlayerStats.Money < TowerToBuild.cost)
        {
            Debug.Log("Not Enough Gold");
            return;
        }

        PlayerStats.Money -= TowerToBuild.cost;

        GameObject tower = (GameObject)Instantiate(TowerToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.tower = tower;

        Debug.Log("Tower Built, Gold Left:" + PlayerStats.Money);
    }
	
   public void SelectTowerToBuild (TowerBluePrint tower)
    {
        TowerToBuild = tower;
    }
}
