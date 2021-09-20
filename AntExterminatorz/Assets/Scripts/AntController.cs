using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntController : MonoBehaviour
{
	public float antSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AntMover();
    }

    void AntMover()
    {
        //this will control the ant movement
		transform.Translate(Vector3.up * Time.deltaTime * antSpeed);
    }
}
