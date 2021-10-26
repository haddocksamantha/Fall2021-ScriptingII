using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int playerHealth;

    private bool collidingWithPlayer;
    
    // Update is called once per frame
    void Update()
    {
        CollisionWithBoundary();
    }

    private void OnTriggerEnter(Collider other)
    {
        CollisionWithPlayer();
        
        if (collidingWithPlayer == true)
        {
            //this will subtract player health
            DestroyEnemyPrefab();
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
        
        //this will subtract points
    }

    void DestroyEnemyPrefab()
    {
        Destroy(gameObject);
        Debug.Log("enemy collision");
        //this will remove the enemy from the scene on collision
    }
}
