using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private GameObject playerGO;
    private void Awake()
    {
        playerGO = gameObject; 
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

   /* private void OnCollisionEnter(Collision collision)
    {
        // 0 : Heart
        // 1 : Explosion
        // 2 : Bomb
        // 3 : Speed
        if (collision.gameObject.CompareTag("PowerupHeart"))
        {
            CollectPowerUp(0); 
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PowerupExplosion"))
        {
            CollectPowerUp(1);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PowerupBomb"))
        {
            CollectPowerUp(2);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PowerupSpeed"))
        {
            CollectPowerUp(3);
            collision.gameObject.SetActive(false);
        }
    }*/
  
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
