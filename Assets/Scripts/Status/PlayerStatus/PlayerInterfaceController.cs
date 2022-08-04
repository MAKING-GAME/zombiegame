using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Player UI�� �����ϴ� ��ũ��Ʈ*/
public class PlayerInterfaceController : MonoBehaviour
{
    /*Status UI�� �̱��� �������� ����
     ���� ������ �޸𸮿� �ϳ��� �����ϴ� ���̱⵵ �ϰ� ���ټ��� Ŭ���� �������� ������� �� �̱��� ������ �����ϴٰ� �Ǵ�*/
    private static PlayerInterfaceController instance;
    public static PlayerInterfaceController PIController 
    { 
        get 
        { 
            if(instance == null)
            {
                return null;
            }
            return instance;
        } 
    }

    [SerializeField] Slider HPBar; //HP�� UI
     
    [SerializeField] Text ammo; //��ź�� UI

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void changeHPBar(float value) // HP�� ������� �� ȣ���Ͽ� HP�� UI�� ����
    {
        HPBar.value = value;
    }

    public void changeAmmo(int restAmmo, int maxAmmo) //��ź���� ������� �� ȣ���Ͽ� ��ź�� UI�� ����
    {
        ammo.text = restAmmo.ToString() + "/" + maxAmmo.ToString();
    }

}
