using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player, Monster, NPC 등 모두 HP를 가지기 때문에 확장성을 고려하여 IHealth 인터페이스를 상속하여 구현한다*/
public interface IHealth
{
    public void healing(float value);
    public void takeDamage(float value);
    public void takeTrueDamage(float value);
}