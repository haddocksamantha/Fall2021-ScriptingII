using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
   void Start()
   {
      Debug.Log("Player data has been loaded.");
   }
   public int score;
   public float health;
}
