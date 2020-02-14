﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    private Vector3[] _positions;

    private void Start()
    {
        Spawn();

    }
    
    void Spawn()
    {
        _positions = new[] //Oyuncularin spawn noktalari-->
            {new Vector3(0, 1, 0), new Vector3(20, 1, 20), new Vector3(20, 1, 0), new Vector3(0, 1, 20)};//<--
        
        
        for (int i = 0; i <1; i++) // Oyunculari haritaya ekleme 
        {
            //TODO: Diğer oyuncuları burada spawn edeceksin
            //TODO: _positions.Lengthe kadar olarak ekle
            GameObject go = Instantiate(player, new Vector3(0,0,0), Quaternion.identity);
            go.transform.position = _positions[i];
        }
        
    }
}
