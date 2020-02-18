using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName ="Powerup")]
public class Powerup : MonoBehaviour //ScriptableObject
{
    /* public string powerupName;
     public Mesh powerupMesh;*/
    public GameObject[] powerups;
    private GameObject go;

    int rndNum;

    public void DropPowerup(Vector3 location)
    {
        rndNum = Random.Range(0, 15);
        if (rndNum == 3)
        {
            go = Instantiate(powerups[0],location, Quaternion.Euler(-90,0,0));
        }
        else if (rndNum == 2)
        {
            go = Instantiate(powerups[1], location, Quaternion.Euler(-90, 0, 0));
        }
        else if (rndNum == 8)
        {
           go = Instantiate(powerups[2], location, Quaternion.Euler(-90, 0, 0));

        }
        else if(rndNum ==12)
        {
            go = Instantiate(powerups[3], location, Quaternion.Euler(-90, 0, 0));
        }
        else
        {
            return;
        }
    }
}
