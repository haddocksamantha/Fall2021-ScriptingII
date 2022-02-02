using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float enemySpeed = 3f;
    
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
