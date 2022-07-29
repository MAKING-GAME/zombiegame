using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    public void HPrecovery(float value);
    public void HPdecrease(float value);
}