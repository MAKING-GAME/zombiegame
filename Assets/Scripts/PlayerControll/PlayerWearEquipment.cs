using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player가 착용한 장비를 관리하는 스크립트*/
public class PlayerWearEquipment : MonoBehaviour
{
    public Equipment handEquipment;

    public void sethandEquipment() //장비 착용 시 초기화하는 메서드
    {
        handEquipment.showInfo();
    }

    //미완성코드
    /*private Equipment handEquipment;
    public Equipment HandEquipment
    {
        set
        {
            if (handEquipment == null)
                sethandEquipment(value);
        }
    }

    public void sethandEquipment(Equipment equipment) //장비 착용 시 초기화하는 메서드
    {
        handEquipment = equipment;
        handEquipment.showInfo();
    }*/

}
