
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyDataSO enemyData;
    //[SerializeField] private playerhealthSO healthData;
    //these will call the player data SO 
    public int playerScore;

    //private int enDamage = 1;
    private int boundDamage = 1;
    private bool collidingWithPlayer;
    
    private void Update()
    {
        CollisionWithBoundary();
    }

    private void OnTriggerEnter(Collider other)
    {
        CollisionWithPlayer();
        
        if (collidingWithPlayer)
        {
            DestroyEnemyPrefab();
            enemyData.numOfEnemies -= 1;
            EnemiesNotBelowZero();
            //   playerHealth -= colDamage;
        }
    }
    
    private void CollisionWithPlayer()
    {
        if (GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = true;
        } else if(!GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = false;
        }
    }

    private void CollisionWithBoundary()
    {
        playerScore -= boundDamage;
        enemyData.numOfEnemies -= 1;
        EnemiesNotBelowZero();
    }

    private void DestroyEnemyPrefab()
    {
        Destroy(gameObject);
//        Debug.Log("enemy collision");
    }

    private void EnemiesNotBelowZero()
    {
        if (enemyData.numOfEnemies <= 0)
        {
            enemyData.numOfEnemies = 0;
        }
    }
}
