using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    
    //private Vector3 playerSpawnPoint = (-70, 6, -38);
    private bool playerAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAlive == false)
        {
            SpawnPlayer();
        }
    }

    void SpawnPlayer()
    {
        
    }
}
