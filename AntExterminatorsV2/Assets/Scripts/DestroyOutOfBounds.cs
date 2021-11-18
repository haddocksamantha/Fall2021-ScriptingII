using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private PlayerScoreSO score;
    [SerializeField] private PenaltySO pSO;
    
    private float topBound = 13;
    private float lowerBound = -11;

    //public Text penaltyText;
    
    private void Start()
    {
       
    }

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
            score.points -= pSO.penalty;
            
            if (score.points <= 0) score.points = 0;
        }
        RunPenaltyText();
    }

    private void RunPenaltyText()
    {
        pSO.penaltyOn = true;
    }

    
    
    
}
