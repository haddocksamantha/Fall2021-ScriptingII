using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class AntSpawner : MonoBehaviour
{
	public GameObject[] antsToSpawn;
	public int numberOfAnts;

	private int randomNumber;
	private Vector3 spawnPos;
	//z = -11 through -51
	private float zRange = 40f;

	void Start()
	{
		numberOfAnts = 0;
	}

    void Update()
    {
		if(numberOfAnts < 1)
		{
			SpawnRandomAnt();
		}
    }
	
	void SpawnRandomAnt()
	{
		//this will generate a random ant prefab into the scene
		randomNumber = Random.Range(0, antsToSpawn.Length);
		Instantiate(antsToSpawn[randomNumber]);
		numberOfAnts++;
	}

	void RandomSpawnPoint()
	{
	  float x = 66f;
      float y = 1.5f;
      float z = Random.Range(-zRange, zRange);
      spawnPos = new Vector3(x,y,z);
      transform.position = spawnPos;
	}
}
