using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player, Monster, NPC �� ��� HP�� ������ ������ Ȯ�强�� ����Ͽ� IHealth �������̽��� ����Ͽ� �����Ѵ�*/
public interface IHealth
{
    public void healing(float value);
    public void takeDamage(float value);
    public void takeTrueDamage(float value);
}