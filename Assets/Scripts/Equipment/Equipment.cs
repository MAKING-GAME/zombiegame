using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour
{
    public float durability; //������

    abstract public void showInfo(); //������븦 �������� �� ������� �ϴ� ������ �����ش�
    abstract public void attack(); //������� �� ���ݸ޼ҵ�
}
