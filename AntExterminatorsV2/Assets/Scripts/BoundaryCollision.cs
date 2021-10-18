using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryCollision : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {
        enemyPrefab = GameObject.FindWithTag("Enemy");
    }
    
    void OnTriggerEnter(Collider other)
    {
        //this will destroy the enemy prefab
        Debug.Log("Enemy Destroyed");
        Destroy(enemyPrefab);
        //this will subtract points from the player
    }


}
