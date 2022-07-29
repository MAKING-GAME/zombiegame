using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour, IHealth, IStamina
{
    public float HP;
    public float SP;
    public void HPrecovery(float value)
    {
        HP += value;
    }
    public void HPdecrease(float value)
    {
        HP -= value;
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
