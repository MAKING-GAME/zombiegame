using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour, IHealth
{
    [SerializeField]
    private PlayerInterfaceController PIController;
    private float maxHP = 100f;
    private float maxSP = 100f;

    private float HP;
    private float SP;

    

    private void Awake()
    {
        HP = maxHP;
        HP = maxSP;
    }

    public void healing(float value)
    {
        Debug.Log(HP);
        HP += value;
        if(HP > maxHP) { HP = maxHP; }
        PIController.changeHPBar(HP / maxHP);
    }
    public void takeDamage(float value)
    {
        Debug.Log(HP);
        HP -= value;
        if (HP < 0) { HP = 0; }
        PIController.changeHPBar(HP / maxHP);
    }

    public void SPrecovery(float value)
    {
        SP += value;
    }
    public void SPdecrease(float value)
    {
        SP -= value;
    }
    
}
