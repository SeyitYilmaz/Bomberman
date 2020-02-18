using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupExplosion : MonoBehaviour
{
    Player player;
    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject.GetComponent<Player>();
        player.CollectPowerUp(1);
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
