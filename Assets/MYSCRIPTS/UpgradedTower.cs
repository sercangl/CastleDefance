using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradedTower : MonoBehaviour
{

    public Transform target;
    [Header("Attributes")]
    public float fireRate = 1.75f;
    private float fireCountDown = 0f;
    public float radius = 2.5f;
    public string enemyTag = "Enemy";
    public GameObject arrowPrefab;
    public Transform firePoint;



    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= radius)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }
    void Update()
    {
        if (target == null)
            return;

        if (fireCountDown <= 0f)
        {
            shoot();
            fireCountDown = 1f / fireRate;
        }
        fireCountDown -= Time.deltaTime;

    }
    void shoot()
    {
        GameObject arrowGO = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        Arrow arrow = arrowGO.GetComponent<Arrow>();
        Debug.Log("Shot spawned");
        if (arrow != null)
            arrow.Seek(target);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
