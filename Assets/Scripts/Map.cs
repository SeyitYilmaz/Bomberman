using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Map : MonoBehaviour
{
   public TileBlock[] tileBlocks;
   private int[,] _groundBlocks;
   private int?[,] _blocks;
   public int mapSizeX;
   public int mapSizeZ;
   
   
   private void Awake()
   {
      mapSizeX = 21;
      mapSizeZ = 21;
   }

   private void Start()
   {
      GenerateVisualMap();
      GenerateMap();
   }
   
   void GenerateVisualMap()
   {
      //Zeminin belirlenmesi
      _groundBlocks = new int[mapSizeX,mapSizeZ];
      _blocks = new int?[mapSizeX,mapSizeZ];
      
      for (int x = 0; x < mapSizeX; x++)
      {
         for (int z = 0; z < mapSizeZ; z++)
         {
            _groundBlocks[x, z] = 0;
         }
      }

     for (int x = 1; x < mapSizeX-1; x+=2)
     {
        for (int z = 1; z < mapSizeZ-1; z+=2)
        {
            _blocks[x, z] = 1;
        }
     }

     int temp;
     for (int x = 0; x < mapSizeX; x++)
     {
        for (int z = 0; z < mapSizeZ; z++)
        {
           temp = UnityEngine.Random.Range(0, 4);
           if (_blocks[x,z] == null)
           {
              
              if (temp>1)
              {
                 _blocks[x, z] = 2;
              }
              else
              {
                 continue;
              }
           }
           else
           {
              continue;
           }
        }
     }
   }
   
   void GenerateMap()
   {
      //Yeri oluşturma
      for (int x = 0; x < mapSizeX; x++)
      {
         for (int z = 0; z < mapSizeZ; z++)
         {
            TileBlock tb = tileBlocks[_groundBlocks[x,z]];
            Instantiate(tb.blockPrefab, new Vector3(x, 0, z), Quaternion.identity);
         }
      }


      //Kırılmaz ve kırılabilir duvar oluşturma
      for (int x = 0; x < mapSizeX; x++)
      {
         for (int z = 0; z < mapSizeZ; z++)
         {
            if (_blocks[x,z].HasValue)
            {
               TileBlock tb = tileBlocks[(int)_blocks.GetValue(x,z)];
               GameObject go = Instantiate(tb.blockPrefab, new Vector3(x, 1, z), Quaternion.identity);
            }
            else
            {
               continue;
            }
         }
      }
   }

  
}
