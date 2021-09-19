using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 20.0f;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
       Movement(); 
    }

    void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerSpeed);
    }
}

