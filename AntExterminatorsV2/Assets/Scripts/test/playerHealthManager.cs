using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class playerHealthManager : MonoBehaviour
{
    [SerializeField] private playerhealthSO healthData;
    private bool collidingWithEnemy;
    private bool collidingWithBullet;

    public UnityEvent isDead;

    public void Dead()
    {
        isDead?.Invoke();
    }

    private void Start()
    {
       // healthData.model.health = 10f;
       healthData.model.lives = 3;
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        collidingWithEnemy = CheckIfCollidingWithEnemy(other);
        collidingWithBullet = CheckIfCollidingWithBullet(other);

        if (collidingWithEnemy)
        {
            HealthCheck();
        }else if (collidingWithBullet)
        {
            HealthCheck();
        }
        
        bool CheckIfCollidingWithEnemy(Collider other)
        {
            Debug.Log("collision");
            Debug.Log(other);
            var result = false; 
		
            if (other.gameObject.tag == "Enemy")
            {
                result = true;
                Debug.Log("Colliding With Enemy");
            } else 
            {
                result = false;
            }
            return result;
        }

        bool CheckIfCollidingWithBullet(Collider other)
        {
            Debug.Log(other);
            var result = false;

            if (other.gameObject.tag == "EnemyBullet")
            {
                result = true;
                Debug.Log("Colliding With Bullet");
            }else
            {
                result = false;
            }

            return result;
        }

        void HealthCheck()
        {
            healthData.damage(1);
            if (healthData.model.lives <= 0)
            {
                healthData.model.lives = 0;
                Dead();
                Debug.Log("DEAD");
            }
        }

    }
    
    

  
    
    

    private void Update()
    {
        // Damage();
        // if (healthData.model.health <= 0)
        // {
        //     Dead();
        // }
        
    }

    // public void Damage()
    // {
    //     if (Input.GetKeyDown(KeyCode.A))
    //     {
    //         healthData.damage(5);
    //     }
    // }

    private void OnEnable()
    {
        //isDead = healthData.isDead;
    }

    private void OnDisable()
    {
        
    }
}
