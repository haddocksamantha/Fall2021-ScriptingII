using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActivating : MonoBehaviour
{
   
    public GameObject bulletPrefab;

    
    public void ShootGun()
    {
        Shoot();
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab,transform.position,transform.rotation);
    }




}
