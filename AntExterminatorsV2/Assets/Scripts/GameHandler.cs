using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
   private int health;
   private void Start()
   {
      HealthSystem healthSystem = new HealthSystem(100);
      
      Debug.Log("health" + healthSystem.GetHealth());
   }

  
}
