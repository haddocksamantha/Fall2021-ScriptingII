using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{

    [SerializeField] private playerhealthSO health; 
    
    private float speed = 6f;
    private float bulletDeathTime = 10f; 

    private bool collidingWithPlayer;

    private void Start()
    {
        StartCoroutine(BulletDeathTimer());
    }

    void Update()
    {
        BulletMovement();
    }

    void BulletMovement()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed );
    }

    private void DestroyTheBullet()
    {
        Destroy(gameObject);
        StartCoroutine(BulletDeathTimer());
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        collidingWithPlayer = CheckIfCollidingWithPlayer(other);
        if (collidingWithPlayer)
        {
            health.damage(1);
            DestroyTheBullet();
        }
    }
    
    private bool CheckIfCollidingWithPlayer(Collider other)
    {
        Debug.Log(other);
        var result = false; 
		
        if (other.gameObject.tag == "Player")
        {
            result = true;
        } else 
        {
            result = false;
        }
        return result;
    }

    IEnumerator BulletDeathTimer()
    {
        yield return new WaitForSeconds(bulletDeathTime);
        DestroyTheBullet();
    }
    
}
