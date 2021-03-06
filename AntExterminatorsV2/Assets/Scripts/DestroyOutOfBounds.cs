using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private PlayerScoreSO score;
    private float topBound = 13f;
    private float lowerBound = -15f;
    private int penalty = 10;
    
    //public Text penaltyText;
    
    private void Start()
    {
       // penaltyText = GetComponent<Text>();
    }

    void Update()
    {
        //destroys objects out of player view
        if (transform.position.x > topBound)
        {
      //      Debug.Log("Passed Right Boundary");
           
        }
        else if (transform.position.x < lowerBound)
        {
            
//            Debug.Log("Passed Left Boundary");
            Destroy(gameObject);
            score.points -= penalty;
            Debug.Log("Passed Left Bound");
            
            if (score.points <= 0) score.points = 0;
        }
        //UpdatePenaltyText();
    }

    private void UpdatePenaltyText()
    {
        //penaltyText.text = ("-" + penalty);
    }
    
    
}
