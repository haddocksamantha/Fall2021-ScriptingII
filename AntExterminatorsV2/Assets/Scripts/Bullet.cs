using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public GameObject bulletPrefab;
	public GameObject enemyPrefab;
	public float bulletSpeed;
	
	void Start()
	{
		enemyPrefab = GameObject.FindWithTag("Enemy");
	}
	
	void Update()
	{
		BulletMovement();
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Enemy Hit!");
		Destroy(enemyPrefab);
		DestroyTheBullet();
	}

    void DestroyTheBullet()
    {
        //this will destroy the bullet when it collides with the enemy 
    }

    void BulletMovement()
    {
	    transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed );
    }

}
