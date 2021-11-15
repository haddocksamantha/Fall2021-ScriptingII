
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
    public float time = 2.5f;
    
    private float enemyX = 8.96000004f;
    private float enemyY = 1.57000005f;
    private float enemyZ;
    private float zRange = 3f;
    private Vector3 enemyTransform;
    
    // Start is called before the first frame update
    void Start()
    {
		//enemyPrefab = GameObject.FindWithTag("Enemy");
        enemyData.numOfEnemies = 0;
        StartCoroutine(EnemySpawnTimer());
    }

    void AreThereEnemies()
    {
        //this will check for how many enemies are in the scene and call spawning method
        if (enemyData.numOfEnemies <= 0)
        {
            enemyData.numOfEnemies = 0;
            SpawnEnemies();
        }  
    }

    void SpawnEnemies()
    {
        enemyData.numOfEnemies++;
        //this will spawn enemies into the scene
        Debug.Log("Enemies: " + enemyData.numOfEnemies);
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
        AreThereEnemies();
        yield return new WaitForSeconds(time);
        StartCoroutine(EnemySpawnTimer());
    }
}


