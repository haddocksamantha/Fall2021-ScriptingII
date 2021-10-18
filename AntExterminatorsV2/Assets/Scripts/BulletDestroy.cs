using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
	public GameObject bulletPrefab;
	public GameObject enemyPrefab;
	
	void Start()
	{
		enemyPrefab = GameObject.FindWithTag("Enemy");

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Enemy Hit!");
		Destroy(enemyPrefab);
	}

    void DestroyTheBullet()
    {
        //this will destroy the bullet when it collides with the enemy 
    }

}
