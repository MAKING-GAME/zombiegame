using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    public void healing(float value);
    public void takeDamage(float value);
    public void takeTrueDamage(float value);
}