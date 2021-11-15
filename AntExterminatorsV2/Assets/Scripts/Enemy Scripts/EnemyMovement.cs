using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 6f;
    
    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * enemySpeed);
    }
}
