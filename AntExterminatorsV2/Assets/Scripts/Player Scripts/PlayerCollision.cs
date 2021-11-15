using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public GameObject enemyPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab = GameObject.FindWithTag("Enemy");
    }

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Player Hit!");
		//this will subtract player health/points and destroy enemy prefab
		//Destroy(enemyPrefab);
	
	}

  
}
