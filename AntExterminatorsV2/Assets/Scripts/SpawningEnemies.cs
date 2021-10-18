
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawningEnemies : MonoBehaviour
{
    public int numOfEnemies;

    private int enemiesNeeded = 1;
    private float enemyX;
    private float enemyY;
    private float enemyZ;
    private float zRange;
    private Vector3 enemyTransform;
    
    // Start is called before the first frame update
    void Start()
    {
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
        if (numOfEnemies == 0)
        {
            SpawnEnemies();
        } else if (numOfEnemies < enemiesNeeded)
        {
            SpawnEnemies();
        }
            
    }

    void SpawnEnemies()
    {
        //this will spawn enemies into the scene
        EnemyTransformGenerator();
        
    }
    
    void EnemyTransformGenerator()
    {
        enemyZ = Random.Range(-zRange, zRange);
        enemyTransform = new Vector3(enemyX, enemyY, enemyZ);
    }
}
