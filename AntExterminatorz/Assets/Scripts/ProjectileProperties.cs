using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileProperties : MonoBehaviour
{
    public float projectileSpeed = 50f;

    private GameObject enemyAnt;
    // Start is called before the first frame update
    void Start()
    {
        enemyAnt = GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        MoveRight();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Ant");
            Destroy(enemyAnt);
            Destroy(this.gameObject);
        }
        
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * projectileSpeed);
    }
}
