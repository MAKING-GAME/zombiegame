using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Equipment
{
    public float damage; //대미지
    public float attackSpeed; //공격속도
    public float noise; //소음발생량

    abstract public void attack();
}
