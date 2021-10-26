using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public Rigidbody enemyRb;
	public float bulletSpeed;

	private bool collidingWithEnemy;
	
	void Start()
	{
		enemyRb = GetComponent<Rigidbody>();
	}
	
	void Update()
	{
		BulletMovement();
	}

	void OnTriggerEnter(Collider other)
	{
		CollidingWithEnemy();
		
		if (collidingWithEnemy == true)
		{
			Debug.Log("Enemy Hit!");
			Destroy(enemyRb);
			DestroyTheBullet();
		}
	}

	void CollidingWithEnemy()
	{
		if (GameObject.FindWithTag("Enemy"))
		{
			collidingWithEnemy = true;
		} else if(!GameObject.FindWithTag("Enemy"))
		{
			collidingWithEnemy = false;
		}
	}

    void DestroyTheBullet()
    {
        //this will destroy the bullet when it collides with the enemy 
        Destroy(gameObject);
    }

    void BulletMovement()
    {
	    transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed );
    }

}
