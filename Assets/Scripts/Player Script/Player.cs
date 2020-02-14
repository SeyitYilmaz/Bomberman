using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public GameObject playerGO;

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public override void Die()
    {
        if (heartCount < 0)
        {
            playerGO.SetActive(false);
            heartCount = startingHeartCount;
        }
    }
}
