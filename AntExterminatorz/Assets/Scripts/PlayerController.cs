using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
    public float playerSpeed;
    private float upAndDownInput;
    //checks for keyboard input
    upAndDownInput = Input.GetAxis("Vertical");
    //moves player up and down
    transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * forwardInput);
    
    }

}
