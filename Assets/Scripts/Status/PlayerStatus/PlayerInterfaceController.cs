using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Player UI를 제어하는 스크립트*/
public class PlayerInterfaceController : MonoBehaviour
{
    /*Status UI를 싱글톤 패턴으로 구현
     게임 내에서 메모리에 하나만 존재하는 것이기도 하고 접근성도 클래스 의존도를 고려했을 때 싱글톤 패턴이 적절하다고 판단*/
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

    [SerializeField] Slider HPBar; //HP바 UI
     
    [SerializeField] Text ammo; //장탄수 UI

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

    public void changeHPBar(float value) // HP가 변경됐을 때 호출하여 HP바 UI를 변경
    {
        HPBar.value = value;
    }

    public void changeAmmo(int restAmmo, int maxAmmo) //장탄수가 변경됐을 때 호출하여 장탄수 UI를 변경
    {
        ammo.text = restAmmo.ToString() + "/" + maxAmmo.ToString();
    }

}
