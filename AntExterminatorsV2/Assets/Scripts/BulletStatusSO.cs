using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BulletStatusSO : ScriptableObject
{
    public bool bulletShooting = false;

    public void ActivateBullet()
    {
        bulletShooting = true;
      
    }

}
