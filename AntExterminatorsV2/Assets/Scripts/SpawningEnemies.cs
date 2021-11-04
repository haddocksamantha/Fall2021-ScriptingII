
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawningEnemies : MonoBehaviour
{
    public int numOfEnemies;
	public GameObject enemyPrefab;


    //private int enemiesNeeded = 1;
    private float enemyX = 8.96000004f;
    private float enemyY = 1.57000005f;
    private float enemyZ;
    private float zRange = 3f;
    private Vector3 enemyTransform;
    
    // Start is called before the first frame update
    void Start()
    {
		//enemyPrefab = GameObject.FindWithTag("Enemy");
        numOfEnemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AreThereEnemies();
    }

    void AreThereEnemies()
    {
        //this will check for how many enemies are in the scene and call spawning method
        if (numOfEnemies <= 0)
        {
            SpawnEnemies();
        }  
    }

    void SpawnEnemies()
    {
		Debug.Log("Enemy Spawned!");
        //this will spawn enemies into the scene
        EnemyTransformGenerator();
		Instantiate(enemyPrefab, enemyTransform, Quaternion.identity);
		numOfEnemies ++;
    }
    
    void EnemyTransformGenerator()
    {
        enemyZ = Random.Range(-zRange, zRange);
        enemyTransform = new Vector3(enemyX, enemyY, enemyZ);
    }
}
