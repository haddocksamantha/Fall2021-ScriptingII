using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class playerhealthSO : ScriptableObject
{
    public playerHealthModel model;

    public void damage(float amount)
    {
        model.health -= amount;
        if(model.health <= 0f)
        {
            model.health = 0f;
            isDead?.Invoke();
        }
        //model.health = model.health - amount;
    }

    public UnityAction isDead;


    //public UnityEvent isDead;
    //public UnityEvent isDamaged;
}
