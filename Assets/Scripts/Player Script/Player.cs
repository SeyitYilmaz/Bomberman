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
    public override void TakeDamage(int amount)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // 0 : Heart
        // 1 : Explosion
        // 2 : Bomb
        // 3 : Speed
        if (collision.gameObject.CompareTag("HeartBooster"))
        {
            CollectPowerUp(0);
        }
    }

    private void CollectPowerUp(int index)
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
    }
}
