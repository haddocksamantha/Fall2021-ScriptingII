using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
	public float spawnX = -9.69999981f;
	public float spawnY = 1.59000003f;
	public float spawnZ = -1.16999996f;
	public GameObject playerPrefab;
	public bool playerAlive;
	
	//private Transform playerTransform;
	private int playerNum;
	
    // Start is called before the first frame update
    void Start()
    {
	    playerNum = 0;
	    playerAlive = false;
	    //playerPrefab = GameObject.FindWithTag("Player");
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
	    OnlyOnePlayer();
	    IsPlayerActive();
    }
	
	void SpawnPlayer() {
		Debug.Log("Player Spawned");
		//this will spawn the player in the scene at its spawn point
		Vector3 playerPos = new Vector3(spawnX, spawnY, spawnZ);

		Instantiate(playerPrefab, playerPos, playerPrefab.transform.rotation);
		playerNum = 1;
		playerAlive = true;
	}

	void IsPlayerActive()
	{
		//this will check if the player is in the scene and spawn if it is not
		if (playerAlive == false)
		{
			SpawnPlayer();
		}
	}

	void OnlyOnePlayer()
	{
		if (playerNum > 1)
		{
			//this will destroy extra player prefabs
		}
	}
	
}
