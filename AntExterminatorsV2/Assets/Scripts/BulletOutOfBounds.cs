using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOutOfBounds : MonoBehaviour
{
    private float boundary = 13;

    [SerializeField] private NumOfBulletsSO bulletSO;
    
    void Update()
    {
        //destroys objects out of player view
        if (transform.position.x > boundary)
        {
           // Debug.Log("Bullet Out of Bounds");
            Destroy(gameObject);
            NumOfBulletsSO.numOfAmmo -= 1;
        }
        
    }
}
