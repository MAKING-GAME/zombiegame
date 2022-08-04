using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Player의 Status를 제어하는 스크립트*/
public class PlayerStatus : MonoBehaviour, IHealth
{
    [SerializeField]
    private float maxHP = 100f; //최대 HP
    private float maxSP = 100f; //최대 SP

    private float HP; //현재 HP
    private float SP; //현재 SP

    [SerializeField] private float armorClass = 0f; // 피해감소량

    private void Awake()
    {
        HP = maxHP;
        HP = maxSP;
    }
    public void healing(float value) //회복 메서드 구현
    {
        Debug.Log(HP);
        HP += value;
        if(HP > maxHP) { HP = maxHP; }
        PlayerInterfaceController.PIController.changeHPBar(HP / maxHP);
    }
    public void takeDamage(float value) //피해 메서드
    {
        float damage = (float)(value * (100 - armorClass) * 0.01);
        HP -= damage;
        if (HP < 0) { HP = 0; }
        PlayerInterfaceController.PIController.changeHPBar(HP / maxHP);
        Debug.Log("HP : " + HP.ToString() + "/Damage : " + damage.ToString());
    }

    public void takeTrueDamage(float value) //고정피해 메서드
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
