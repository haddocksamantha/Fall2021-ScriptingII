using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletButton : MonoBehaviour
{
   public static bool bulletStatus;
   private float time = 5f; 
   
   public void PlayerShootBullet()
   {
      StartCoroutine(BulletTimer());
   }

   IEnumerator BulletTimer()
   {
      bulletStatus = true;
      yield return new WaitForSeconds(time);
      bulletStatus = false;
   }
}
