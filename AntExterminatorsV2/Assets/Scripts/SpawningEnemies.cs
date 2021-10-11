using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        AreThereEnemies();
    }

    void AreThereEnemies()
    {
        //this will check for how many enemies are in the scene and call spawning method
    }

    void SpawnEnemies()
    {
        //this will spawn enemies into the scene
    }
}
