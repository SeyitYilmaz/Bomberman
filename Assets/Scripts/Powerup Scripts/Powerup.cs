using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName ="Powerup")]
public class Powerup : MonoBehaviour //ScriptableObject
{
    /* public string powerupName;
     public Mesh powerupMesh;*/
    public GameObject[] powerups;

    int rndNum;

    public void DropPowerup(Vector3 location)
    {
        rndNum = Random.Range(0, 10);
        if (rndNum == 3)
        {
            GameObject go = Instantiate(powerups[0],location, Quaternion.Euler(-90,0,0));
        }
        else if (rndNum == 2)
        {
            GameObject go = Instantiate(powerups[1], location, Quaternion.Euler(-90, 0, 0));
        }
        else if (rndNum == 8)
        {
            GameObject go = Instantiate(powerups[2], location, Quaternion.Euler(-90, 0, 0));

        }
        else
        {
            return;
        }
    }
}
