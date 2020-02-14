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
    protected int startingBombCount;
    protected int startingBoostCount;
    protected int startingHeartCount;
    
    private GameObject character;

    private void Awake()
    {
        bombCount = startingBombCount;
        boostCount = startingBoostCount;
        heartCount = startingHeartCount;
    }

    public abstract void Die();
    public abstract void TakeDamage(int amount);
    public abstract void TakeBooster();

}
    
