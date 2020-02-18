using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private GameObject playerGO;
    private float maxSpeed = 18f;
    PlayerController playercon;
    private void Awake()
    {
        playerGO = gameObject;
        playercon = GetComponent<PlayerController>();
    }

    public override void Die()
    {
        if (heartCount < 0)
        {
            playerGO.SetActive(false);
            heartCount = startingHeartCount;
        }
    }
    public override void TakeDamage(int amount)
    {

    } 
    public void CollectPowerUp(int index)
    {
        if (index == 0)
        {
            heartCount++;
        }
        else if(index == 1)
        {
            boostCount++;
        }
        else if (index == 2)
        {
            bombCount++;
        }
        else if(index == 3)
        {
            playercon.moveSpeed = playercon.moveSpeed + 2;
        }

        if (heartCount > maxHeartCount)
        {
            heartCount = maxHeartCount;
        }
        if (bombCount > maxBombCount)
        {
            bombCount = maxBombCount;
        }
        if (boostCount > maxBoostCount)
        {
            boostCount = maxBoostCount;
        }
        if (playercon.moveSpeed > maxSpeed)
        {
            playercon.moveSpeed = maxSpeed;
        }
    }
}
