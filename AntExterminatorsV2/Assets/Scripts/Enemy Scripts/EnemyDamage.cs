
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyDataSO enemyData;
    //[SerializeField] private playerhealthSO healthData;
    //these will call the player data SO 
    public int playerScore;
    private bool isCollidingWithPlayer;

    //private int enDamage = 1;
    private int boundDamage = 1;
    private bool collidingWithPlayer;
    
    private void Update()
    {
        CollisionWithBoundary();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemy colliding");
        isCollidingWithPlayer = CollidingWithPlayer(other);
        
        if (isCollidingWithPlayer)
        {
            DestroyEnemyPrefab();
            enemyData.numOfEnemies -= 1;
            EnemiesNotBelowZero();
            //   playerHealth -= colDamage;
        }
    }
    bool CollidingWithPlayer(Collider other)
    {
        Debug.Log(other);
        var result = false;
        
        if (other.gameObject.tag == "Player")
        {
            result = true;
            Debug.Log("enemy colliding with player");
        } else
        {
            result = false;
        }
        return result;
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
