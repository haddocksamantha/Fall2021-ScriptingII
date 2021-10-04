using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDeath : MonoBehaviour
{
	void OnCollisionEnter(Collision col)
	{
		Destroy(gameObject);
		Destroy(col.gameObject);
	}
}
