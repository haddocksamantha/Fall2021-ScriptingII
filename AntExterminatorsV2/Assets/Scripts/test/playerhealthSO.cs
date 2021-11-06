using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class playerhealthSO : ScriptableObject
{
    public playerHealthModel model;

    // public void damage(float amount)
    // {
    //     model.health -= amount;
    //     if(model.health <= 0f)
    //     {
    //         model.health = 0f;
    //         isDead?.Invoke();
    //     }
    //     //model.health = model.health - amount;
    // }

    public void damage(int amt)
    {
        model.lives -= amt;
        if (model.lives <= 0)
        {
            model.lives = 0;
            isDead?.Invoke();
        }
    }

    public UnityAction isDead;


    //public UnityEvent isDead;
    //public UnityEvent isDamaged;
}
