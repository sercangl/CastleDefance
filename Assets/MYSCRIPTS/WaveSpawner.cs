using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 30f;
    private float countDown = 0f;
    private int waveNumber = 0;
    public Transform spawnPoint;


    void Update()
    {
        if (countDown <= -10f)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        Debug.Log("Wave Incoming");
        waveNumber++;
        for (int i = 0; i < waveNumber; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
    }
    void spawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);


    }
    /*private void OnTriggerEnter(Collider col)
    {
        if(col.tag=="bullet"){
            Destroy(col.gameObject);
            Destroy(gameObject);
        }

    }*/
}
