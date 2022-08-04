using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour
{
    public float durability; //내구도

    abstract public void showInfo(); //장비착용를 착용했을 때 보여줘야 하는 정보를 보여준다
    abstract public void attack(); //장비착용 후 공격메소드
}
