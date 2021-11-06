using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class playerHealthManager : MonoBehaviour
{
    [SerializeField] private playerhealthSO healthData;

    public UnityEvent isDead;

    public void Dead()
    {
        isDead?.Invoke();
    }

    private void Start()
    {
       // healthData.model.health = 10f;
       healthData.model.lives = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        healthData.damage(1);
        if (healthData.model.lives <= 0)
        {
            Dead();
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
