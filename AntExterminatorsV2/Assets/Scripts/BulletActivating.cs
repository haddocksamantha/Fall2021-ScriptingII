using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActivating : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Update is called once per frame

    void Start()
    {
        //bulletPrefab = GameObject.FindWithTag("Bullet");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            //Debug.Log("Bullet Shot!)");
            Instantiate(bulletPrefab,transform.position,transform.rotation);

        }
        //this will spawn bullets into the scene when player clicks the button  
    }
    
    
    
    
}
