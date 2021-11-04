using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //these will call the player data SO 
    public int playerHealth;
    public int playerScore;

    private int enDamage = 1;
    private int boundDamage = 1;
    private bool collidingWithPlayer;
    
    void Update()
    {
        CollisionWithBoundary();
    }

    private void OnTriggerEnter(Collider other)
    {
        CollisionWithPlayer();
        
        if (collidingWithPlayer == true)
        {
            DestroyEnemyPrefab();
         //   playerHealth -= colDamage;
        }
    }
    
    void CollisionWithPlayer()
    {
        if (GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = true;
        } else if(!GameObject.FindWithTag("Player"))
        {
            collidingWithPlayer = false;
        }
    }

    void CollisionWithBoundary()
    {
        playerScore -= boundDamage;
    }

    void DestroyEnemyPrefab()
    {
        Destroy(gameObject);
        Debug.Log("enemy collision");
    }
}
