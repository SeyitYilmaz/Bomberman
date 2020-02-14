using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected int bombCount;
    [SerializeField]
    protected int boostCount;
    [SerializeField]
    protected int heartCount;
    [SerializeField]
    protected int startingBombCount = 1;
    protected int startingBoostCount = 2;
    protected int startingHeartCount = 0;
    protected int maxBombCount = 4;
    protected int maxBoostCount = 5;
    protected int maxHeartCount = 3;

    private GameObject character;
    private void Awake()
    {
        bombCount = startingBombCount;
        boostCount = startingBoostCount;
        heartCount = startingHeartCount;
    }


    public abstract void Die();
    public abstract void TakeDamage(int amount);

}
    
