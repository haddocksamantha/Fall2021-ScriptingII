using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMoveV2 : MonoBehaviour
{
    public float playerSpeed = 5f;

    private float verticalInput;
	private float zRange = 3f;

	private FixedJoystick joystick;

	private void Awake()
	{
		joystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
	}

	// Update is called once per frame
    void Update()
    {
        OutOfBounds();
		PlayerMovementInput();
    }

	void PlayerMovementInput()
	{
		verticalInput = joystick.Vertical;
		transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);
	}

    void OutOfBounds()
    {
        //this will make the player stay on the plane
		//3 and negative 3 on the z axis are the boundaries
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