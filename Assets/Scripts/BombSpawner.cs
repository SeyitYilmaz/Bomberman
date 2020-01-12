using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
   public GameObject bomb;
   private  GameObject bombSpawnPosition;

   private void Start()
   {
      bombSpawnPosition = gameObject.transform.GetChild(0).gameObject;
   }

   private void Update()
   {
      SpawnBomb();
   }

   void SpawnBomb()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Instantiate(bomb, bombSpawnPosition.transform.position, Quaternion.identity);
      }
   }
}
