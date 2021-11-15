using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private PlayerScoreSO score;
    private float topBound = 13;
    private float lowerBound = -11;

    private int penalty = 3;
    
    void Update()
    {
        //destroys objects out of player view
        if (transform.position.x > topBound)
        {
      //      Debug.Log("Passed Right Boundary");
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            
//            Debug.Log("Passed Left Boundary");
            Destroy(gameObject);
            score.points -= penalty;
            if (score.points <= 0) score.points = 0;
        }

    }
}
