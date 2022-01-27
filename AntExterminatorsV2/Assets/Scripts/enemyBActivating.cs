using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBActivating : MonoBehaviour
{
  public GameObject enemyBullet;
  private float time = 10f;

  private void Start()
  {
    SpawnBullet();
    StartCoroutine(BulletSpawnTimer());
  }

  void SpawnBullet()
  {
    Instantiate(enemyBullet, transform.position, transform.rotation);
  }
  
  IEnumerator BulletSpawnTimer()
  {
    yield return new WaitForSeconds(time);
    SpawnBullet();
    StartCoroutine(BulletSpawnTimer());
  }
  
}
