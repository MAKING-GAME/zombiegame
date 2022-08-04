using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*원거리 무기(총, 활, 석궁 등)의 기능들을 인터페이스로 분류 - 확장 가능성 염두*/
public interface RangedWeapon
{
    public void fire();
    public void reload();
}