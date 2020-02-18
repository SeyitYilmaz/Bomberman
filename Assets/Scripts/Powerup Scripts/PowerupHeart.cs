using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHeart : MonoBehaviour
{
    Player player;
    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject.GetComponent<Player>();
        player.CollectPowerUp(0);
        if (other.gameObject.CompareTag("Player"))
        {
            player.CollectPowerUp(0);
            gameObject.SetActive(false);
        }
    }
}
