using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        CollisionWithPlayer();
        CollisionWithBoundary();
    }

    void CollisionWithPlayer()
    {
        //this will damage the player 
        DestroyEnemyPrefab();
    }

    void CollisionWithBoundary()
    {
        //this will subtract points
        DestroyEnemyPrefab();
    }

    void DestroyEnemyPrefab()
    {
        //this will remove the enemy from the scene on collision
    }
}
