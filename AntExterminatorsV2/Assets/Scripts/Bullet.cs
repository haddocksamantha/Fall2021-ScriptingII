using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	public float bulletSpeed;

	private bool collidingWithEnemy;
	
	private void Start()
	{
		
	}
	
	private void Update()
	{
		BulletMovement();
	}

	// private void OnTriggerEnter(Collider other)
	// {
	// 	CheckIfCollidingWithEnemy();
	// 	
	// 	if (collidingWithEnemy == true)
	// 	{
	// 		Debug.Log("Enemy Hit!");
	// 		Destroy(enemyRb);
	// 		DestroyTheBullet();
	// 	}
	// }

	private void OnTriggerEnter(Collider other)
	{
		collidingWithEnemy = CheckIfCollidingWithEnemy(other);
		if (collidingWithEnemy)
		{
			Destroy(other.gameObject);
		}
	}

	private bool CheckIfCollidingWithEnemy(Collider other)
	{
		Debug.Log(other);
		var result = false; 
		if (other.gameObject.tag == "Enemy")
		{
		//	collidingWithEnemy = true;
			result = true;
		} else 
		{
			result = false;
			//	collidingWithEnemy = false;
		}
		return result;
	}

    private void DestroyTheBullet()
    {
        //this will destroy the bullet when it collides with the enemy 
        Destroy(gameObject);
    }

    private void BulletMovement()
    {
	    transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed );
    }

}
