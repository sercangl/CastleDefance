using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public TowerBluePrint StandardTower;
    public TowerBluePrint UpgradedTower;
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTower()
    {
        Debug.Log("Standard Tower Purchased");
        buildManager.SelectTowerToBuild(StandardTower);
    }

public void SelectAnotherTower()
    {
        Debug.Log("Another Tower Purchased");
        buildManager.SelectTowerToBuild(UpgradedTower);
    }



}
