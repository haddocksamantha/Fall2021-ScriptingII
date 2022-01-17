using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActivating : MonoBehaviour
{
   
    public GameObject bulletPrefab;

    [SerializeField]private NumOfBulletsSO bulletSO;

    public float time = 0.5f;
    public bool canShoot;

    void Start()
    {
        NumOfBulletsSO.numOfAmmo = 0;
        canShoot = true;
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            ShootGun();
        }
    }

    public void ShootGun()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (canShoot)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            StartCoroutine(BulletShootTimer());
            NumOfBulletsSO.numOfAmmo += 1;
        }
    }


    IEnumerator BulletShootTimer()
    {
        canShoot = false;
        yield return new WaitForSeconds(time);
        canShoot = true;

    }
    
}
