using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player�� Status�� �����ϴ� ��ũ��Ʈ*/
public class PlayerStatus : MonoBehaviour, IHealth
{
    [SerializeField]
    private float maxHP = 100f; //�ִ� HP
    private float maxSP = 100f; //�ִ� SP

    private float HP; //���� HP
    private float SP; //���� SP

    [SerializeField] private float armorClass = 0f; // ���ذ��ҷ�

    private void Awake()
    {
        HP = maxHP;
        HP = maxSP;
    }
    public void healing(float value) //ȸ�� �޼��� ����
    {
        Debug.Log(HP);
        HP += value;
        if(HP > maxHP) { HP = maxHP; }
        PlayerInterfaceController.PIController.changeHPBar(HP / maxHP);
    }
    public void takeDamage(float value) //���� �޼���
    {
        float damage = (float)(value * (100 - armorClass) * 0.01);
        HP -= damage;
        if (HP < 0) { HP = 0; }
        PlayerInterfaceController.PIController.changeHPBar(HP / maxHP);
        Debug.Log("HP : " + HP.ToString() + "/Damage : " + damage.ToString());
    }

    public void takeTrueDamage(float value) //�������� �޼���
    {
        float damage = value;
        HP -= damage;
        if (HP < 0) { HP = 0; }
        PlayerInterfaceController.PIController.changeHPBar(HP / maxHP);
        Debug.Log("HP : " + HP.ToString() + "/Damage : " + damage.ToString());
    }

    public void SPrecovery(float value)
    {
        SP += value;
    }
    public void SPdecrease(float value)
    {
        SP -= value;
    }
    
}
