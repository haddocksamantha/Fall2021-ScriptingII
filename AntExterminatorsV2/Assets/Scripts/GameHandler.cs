using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private PlayerScoreSO playerScore;
   private void Start()
   {
       playerScore.points = 0;
   }

  
}
