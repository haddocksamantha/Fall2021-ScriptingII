using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        ShootProjectile();
    }
	
	void ShootProjectile()
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			Debug.Log("Projectile Fired");
			GameObject.Instantiate(projectilePrefab, transform.position, transform.rotation);
		}
	}
}
