using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 20.0f;
    public float zRange = 42f;
    public PlayerDataSO playerData;
    
    private float verticalInput;
    

    // Update is called once per frame
    void Update()
    {
       Movement();
       OutOfBounds();
    }

    void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerSpeed);
    }

    void OutOfBounds()
    {
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}

