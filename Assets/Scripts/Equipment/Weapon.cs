using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Equipment
{
    public float damage; //�����
    public float attackSpeed; //���ݼӵ�
    public float noise; //�����߻���

    abstract public void attack();
}
