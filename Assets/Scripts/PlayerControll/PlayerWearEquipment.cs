using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player�� ������ ��� �����ϴ� ��ũ��Ʈ*/
public class PlayerWearEquipment : MonoBehaviour
{
    public Equipment handEquipment;

    public void sethandEquipment() //��� ���� �� �ʱ�ȭ�ϴ� �޼���
    {
        handEquipment.showInfo();
    }

    //�̿ϼ��ڵ�
    /*private Equipment handEquipment;
    public Equipment HandEquipment
    {
        set
        {
            if (handEquipment == null)
                sethandEquipment(value);
        }
    }

    public void sethandEquipment(Equipment equipment) //��� ���� �� �ʱ�ȭ�ϴ� �޼���
    {
        handEquipment = equipment;
        handEquipment.showInfo();
    }*/

}
