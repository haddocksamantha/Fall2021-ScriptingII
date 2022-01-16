
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System;



public class SpawningEnemies : MonoBehaviour
{
    [SerializeField] private EnemyDataSO enemyData;
    
 
	public GameObject enemyPrefab;
    public float time = 1f;
   // public bool canSpawn = true;
    
    private float enemyX = 8.96000004f;
    private float enemyY = 1.57000005f;
    private float enemyZ;
    private float zRange = 3f;
    private Vector3 enemyTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyData.numOfEnemies = 0;
        StartCoroutine(EnemySpawnTimer());
    }
    
    void SpawnEnemies()
    {
        enemyData.numOfEnemies++;
        EnemyTransformGenerator();
        Instantiate(enemyPrefab, enemyTransform, Quaternion.identity);
    }
    
    void EnemyTransformGenerator()
    {
        enemyZ = Random.Range(-zRange, zRange);
        enemyTransform = new Vector3(enemyX, enemyY, enemyZ);
    }

    IEnumerator EnemySpawnTimer()
    {
        yield return new WaitForSeconds(time);
        SpawnEnemies();
        StartCoroutine(EnemySpawnTimer());
    }
}


//while (canSpawn)